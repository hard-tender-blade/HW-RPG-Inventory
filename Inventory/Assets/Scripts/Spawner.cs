using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject itemToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        SpawnItem();
    }

    public void SpawnItem() {
        GameObject newItem = Instantiate(itemToSpawn);
        newItem.transform.SetParent(transform);
    }
}
