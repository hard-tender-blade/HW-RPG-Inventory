using UnityEngine;
using UnityEngine.EventSystems;
public class SlotUI : MonoBehaviour, IDropHandler
{
    // ? OnDrop is called when the user releases the mouse button while
    // ? the mouse is over the GUIElement or Collider.
    public void OnDrop(PointerEventData eventData)
    {
        if(transform.childCount == 0) {
            GameObject dropped = eventData.pointerDrag;
            ItemUI draggableItem = dropped.GetComponent<ItemUI>();
            draggableItem.parentAfterDrug = transform;
        }
    }
}
