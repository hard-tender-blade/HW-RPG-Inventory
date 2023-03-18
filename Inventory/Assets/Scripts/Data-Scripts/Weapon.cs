public class Weapon : Item
{
    // * "base" is a keyword that refers to the base class constructor
    // * Modifycator "ovveride" is a keyword that means that the method is overriden from the base class (Item)
    private int quality { get; set; }
    public Weapon(string name, int weight, int quality) : base(name, weight)
    {
        this.quality = quality;
    }
    public override void DoDamage() => quality--;
    public override bool IsDestroyed() => quality <= 0;
    public override string GetDescription() => $"{name}\n w:{weight} q:{quality}";
}