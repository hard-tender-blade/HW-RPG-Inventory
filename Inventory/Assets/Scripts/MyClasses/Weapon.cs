public class Weapon : Item
{
    public int quality { get; set; }

    public override string GetDescription() {
        return $"{name}\n w:{weight} q:{quality}";
    }
}