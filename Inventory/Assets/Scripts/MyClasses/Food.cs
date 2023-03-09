public class Food : Item
{
    public int amount { get; set; }

    public override string GetDescription() {
        return $"{name}\n w:{weight} a:{amount}";
    }
}