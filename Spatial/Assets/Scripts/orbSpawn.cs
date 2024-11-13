using System.Collections;
using UnityEngine;

public class orbSpawn : MonoBehaviour
{
    // Array of points where the prefab can be instantiated
    public Transform[] spawnPoints;

    // Array of prefabs to randomly instantiate (for this example, circles)
    public GameObject[] prefabs;

    // Interval for respawning circles
    public float respawnInterval = 3f;

    void Start()
    {
        // Start the respawning process
        StartCoroutine(RespawnPrefab());
    }

    // Coroutine to respawn a prefab every 3 seconds
    IEnumerator RespawnPrefab()
    {
        while (true)
        {
            // Pick a random spawn point
            int randomSpawnIndex = Random.Range(0, spawnPoints.Length);

            // Pick a random prefab (circle)
            int randomPrefabIndex = Random.Range(0, prefabs.Length);

            // Randomly choose a color (tag)
            string randomColorTag = GetRandomColorTag();
        
            // Instantiate the prefab at the selected spawn point
            GameObject newPrefab = Instantiate(prefabs[randomPrefabIndex], spawnPoints[randomSpawnIndex].position, Quaternion.identity);

            // Attach the orbSlotScript script to the newly spawned object
            DragAndDrop2D orbSlotScript = newPrefab.AddComponent<DragAndDrop2D>();

            // Set the spawn point as the drop target slot for the drag-and-drop functionality (optional)
            orbSlotScript.slot = spawnPoints[randomSpawnIndex]; // This can be modified if you want different logic for slotting.

            // Optionally, make sure the prefab has a CircleCollider2D or another suitable collider
            if (newPrefab.GetComponent<Collider2D>() == null)
            {
                newPrefab.AddComponent<CircleCollider2D>();
            }

            // Wait for the next respawn interval
            yield return new WaitForSeconds(respawnInterval);
        }
    }
    private string GetRandomColorTag()
    {
        string[] colorTags = { "work", "leisure", "relationships", "personal" };
        int index = Random.Range(0, colorTags.Length);
        return colorTags[index];
    }

}
