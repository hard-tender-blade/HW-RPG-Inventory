using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotUI : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if(transform.childCount == 0) {
            GameObject dropped = eventData.pointerDrag;
            ItemUI draggableItem = dropped.GetComponent<ItemUI>();
            draggableItem.parentAfterDrug = transform;
        }
    }
}
