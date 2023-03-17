using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    private GameObject oldParent;
    [HideInInspector] public Item item;
    [HideInInspector] public Transform parentAfterDrug;

    [System.Obsolete]
    void Start() {
        GameObject parent = gameObject.transform.parent.gameObject;
        if(parent.tag == "Spawner")  {
            switch (parent.GetComponent<SpawnerUI>().itemToSpawn.tag)
            {
                case "Food":
                    item = new Food{name = "Meat", weight = 10, amount = 3};
                    break;
                case "Weapon":
                    item = new Weapon{name = "Axe", weight = 25, quality = 5};
                    break;
                case "Other":
                    item = new Item{name = "Shoes", weight = 10};
                    break;
            }
        }
        SetDescription();
    }

    void Update() {
        SetDescription();
        if(item.IsDestroyed())
            Destroy(gameObject);
    }

    public void SetDescription() {
        gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>()
        .text = item.GetDescription();
    }

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

        //spawn next item if it is spawner
        if(oldParent.tag == "Spawner" && parentAfterDrug.tag == "Slot") {
            oldParent.GetComponent<SpawnerUI>().SpawnItem();
            // Debug.Log(int.Parse(parentAfterDrug.name.Split(' ')[1]));
            Inventory.AddItem(item);
            //GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().CalcWeight();
        }

        Debug.Log(oldParent.name + "->" + parentAfterDrug.name);
    }
}
