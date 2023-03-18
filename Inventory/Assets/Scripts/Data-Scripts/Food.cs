public class Food : Item
{
    // * "base" is a keyword that refers to the base class constructor
    // * Modifycator "ovveride" is a keyword that means that the method is overriden from the base class (Item)
    private int amount { get; set; }
    public Food(string name, int weight, int amount) : base(name, weight)
    {
        this.amount = amount;
    }
    public override void DoDamage() => amount--;
    public override bool IsDestroyed() => amount <= 0;
    public override string GetDescription() => $"{name}\n w:{weight} a:{amount}";
}