using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public TMPro.TextMeshProUGUI sumweight;

    [System.Obsolete]
    public void GoToNextDay() {
        List<GameObject> ChildsList = GetAllChilds(gameObject);
        foreach (var child in ChildsList)
        {
            if(child.transform.GetChildCount() == 1) {
                child.transform.GetChild(0)
                    .GetComponent<DraggableItem>()
                    .OneDayHasPassed();
            }
        }
        CalcWeight();
    }

    [System.Obsolete]
    public void CalcWeight() {
        int weight = 0;
        List<GameObject> ChildsList = GetAllChilds(gameObject);
        foreach (var child in ChildsList)
        {
            if(child.transform.GetChildCount() == 1) {
                weight += child.transform.GetChild(0)
                            .GetComponent<DraggableItem>()
                            .item.weight;
            }
        }
        sumweight.text = $"Total weight: {weight} kg";
    }

    private List<GameObject> GetAllChilds(GameObject Go)
    {
        List<GameObject> list = new List<GameObject>();
        for (int i = 0; i< Go.transform.childCount; i++)
        {
            list.Add(Go.transform.GetChild(i).gameObject);
        }
        return list;
    }
}
