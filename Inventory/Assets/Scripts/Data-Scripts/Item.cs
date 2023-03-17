public class Item
{
    public string name { get; set; }
    public int weight { get; set; }

    public virtual bool IsDestroyed() {
        return false;
    }
    public virtual void DoDamage() {}
    public virtual string GetDescription() {
        return $"{name}\n w:{weight}";
    }
}