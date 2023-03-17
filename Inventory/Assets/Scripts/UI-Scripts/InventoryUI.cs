using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI sumweight;

    void Update() {
        UpdateWeight();
    }

    private void UpdateWeight() {
        sumweight.text = $"Total weight: {Inventory.GetWeight().ToString()} kg";
    }

    public void OneDayHasPassed() {
        Inventory.OneDayHasPassed();
    }
}
