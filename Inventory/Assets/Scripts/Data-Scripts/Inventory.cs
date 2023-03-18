using System.Collections.Generic;

public class Inventory // ? This class is a singleton
{
    private static List<Item> items = new List<Item>();
    private static int weight = 0;
    public static int GetInventoryWeight() => weight;
    public static void AddItem(Item item)
    {
        items.Add(item);
        weight += item.GetWeight();
    }
    public static void RemoveItem(Item item)
    {
        items.Remove(item);
        weight -= item.GetWeight();
    }

    // ? This method is called from InventoryUI.cs
    // ? This method called when the player clicks the button "One day has passed"
    // ? This method calls the DoDamage() method on all items in the inventory
    public static void OneDayHasPassed() {
        List<Item> itemsToRemove = new List<Item>();
        foreach (var item in items)
        {
            item.DoDamage();
            if(item.IsDestroyed())
                itemsToRemove.Add(item);
        }
        foreach (var item in itemsToRemove)
        {
            RemoveItem(item);
        }
    }
}