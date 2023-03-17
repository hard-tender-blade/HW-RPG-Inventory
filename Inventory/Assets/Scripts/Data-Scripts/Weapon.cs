public class Weapon : Item
{
    public int quality { get; set; }

    public override void DoDamage() {
        quality--;
    }

    public override bool IsDestroyed() => quality <= 0;

    public override string GetDescription() {
        return $"{name}\n w:{weight} q:{quality}";
    }
}