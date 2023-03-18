using UnityEngine;
public class InventoryUI : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI sumweight;

    // ? Update is called once per frame
    private void Update() => UpdateWeight();
    private void UpdateWeight() => sumweight.text = $"Total weight: {Inventory.GetInventoryWeight().ToString()} kg";

    // ? This method is called from the button
    public void OneDayHasPassed() => Inventory.OneDayHasPassed();
}
