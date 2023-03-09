using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    private GameObject oldParent;
    [HideInInspector] public Item item;
    [HideInInspector] public Transform parentAfterDrug;

    void Start() {
        GameObject parent = gameObject.transform.parent.gameObject;
        if(parent.tag == "Spawner")  {
            switch (parent.GetComponent<Spawner>().itemToSpawn.tag)
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

    [System.Obsolete]
    public void OneDayHasPassed() {
        GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().CalcWeight();
        if(item is Food) {
            Food food = item as Food;
            food.amount--;
            if(food.amount == 0)
                Destroy(gameObject);
        }

        if(item is Weapon) {
            Weapon food = item as Weapon;
            food.quality--;
            if(food.quality == 0)
                Destroy(gameObject);
        }

        SetDescription();
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
        Debug.Log(oldParent.name);
        if(oldParent.tag == "Spawner" && parentAfterDrug.tag == "Slot") {
            Debug.Log(oldParent.name);
            oldParent.GetComponent<Spawner>().SpawnItem();
            GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().CalcWeight();
        }   
    }
}
