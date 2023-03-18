public class Item // ? This is the base class for all items in the game
{
    // * Modifycator "protected" means that the variable can be accessed from the derived classes
    // * "=>" is a shorthand for a method that returns a value called a lambda expression
    // * Modifycator "virtual" means that the method can be overriden in the derived classes
    protected string name { get; set; }
    protected int weight { get; set; }
    public Item(string name, int weight)
    {
        this.name = name;
        this.weight = weight;
    }
    public int GetWeight() => weight;
    public virtual bool IsDestroyed() => false;
    public virtual void DoDamage() {}
    public virtual string GetDescription() => $"{name}\n w:{weight}";
}