public class Food : Item
{
    public int amount { get; set; }
    public override void DoDamage() {
        amount--;
    }
    public override bool IsDestroyed() => amount <= 0;
    public override string GetDescription() {
        return $"{name}\n w:{weight} a:{amount}";
    }
}