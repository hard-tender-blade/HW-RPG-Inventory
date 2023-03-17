
using System.Collections.Generic;

public class Inventory
{
    private static List<Item> items = new List<Item>();
    private static int weight = 0;
    public static void AddItem(Item item)
    {
        items.Add(item);
        weight += item.weight;
    }

    public static void RemoveItem(Item item)
    {
        items.Remove(item);
        weight -= item.weight;
    }

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

    public static int GetWeight() {
        return weight;
    }
}