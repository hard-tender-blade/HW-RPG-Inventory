public class Item
{
    public string name { get; set; }
    public int weight { get; set; }

    public virtual string GetDescription() {
        return $"{name}\n w:{weight}";
    }
}