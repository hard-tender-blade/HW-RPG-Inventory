using UnityEngine;
public class SpawnerUI : MonoBehaviour
{
    public GameObject itemToSpawn;

    // ? Start is called before the first frame update
    private void Start() => SpawnItem();

    public void SpawnItem() {
        GameObject newItem = Instantiate(itemToSpawn);
        newItem.transform.SetParent(transform);
    }
}
