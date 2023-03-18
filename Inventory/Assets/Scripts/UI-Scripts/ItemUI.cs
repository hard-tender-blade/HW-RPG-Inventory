using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // * This class inherits one class and implements three interfaces
    [SerializeField] private Image image;
    [HideInInspector] public Item item;
    [HideInInspector] public Transform parentAfterDrug;
    private GameObject oldParent;
    private TMPro.TextMeshProUGUI itemDescription;

    [System.Obsolete]
    void Start() {
        GameObject parent = gameObject.transform.parent.gameObject;
        if(parent.tag == "Spawner")  {
            switch (parent.GetComponent<SpawnerUI>().itemToSpawn.tag)
            {
                case "Food":
                    item = new Food("Meat", 10, 3);
                    break;
                case "Weapon":
                    item = new Weapon("Sword", 25, 5);
                    break;
                case "Other":
                    item = new Item("Shoes", 5);
                    break;
            }
        }

        // ? Get the TextMeshProUGUI component from the child of the game object
        itemDescription = gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>();
        SetDescription();
    }

    // ? Update is called once per frame
    private void Update() {
        SetDescription();
        if(item.IsDestroyed())
            Destroy(gameObject);
    }

    public void SetDescription() => itemDescription.text = item.GetDescription();

    // ? Unity Event System methods (not important)
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        oldParent = gameObject.transform.parent.gameObject;
        parentAfterDrug = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }
    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    [System.Obsolete]
    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrug);
        image.raycastTarget = true;

        // ? If the item is dropped in the inventoryUI, add it to the inventory & spawn a new item
        if(oldParent.tag == "Spawner" && parentAfterDrug.tag == "Slot") {
            oldParent.GetComponent<SpawnerUI>().SpawnItem();
            Inventory.AddItem(item);
        }
    }
}
