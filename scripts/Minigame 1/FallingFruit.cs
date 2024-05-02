using UnityEngine;

public class FallingFruit : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    public float spawnInterval = 0.5f;
    public float spawnIntervalVariance = 0.5f;
    public float initialDelay = 1.0f;

    public Vector2 spawnRangeX = new Vector2(-5f, 5f); // Range of X coordinates
    public float spawnY = 10f; // Y coordinate for spawning

    private float timer = 0.0f;

    void Start()
    {
    }

    void Update()
    {
        timer += Time.deltaTime;
    }

    public void BeginSpawning()
    {
        InvokeRepeating("SpawnObject", initialDelay, spawnInterval);
    }

    public void StopSpawning()
    {
        CancelInvoke("SpawnObject");
    }

    void SpawnObject()
    {
        // Check if objectPrefabs array is not null and has at least one prefab
        if (objectPrefabs != null && objectPrefabs.Length > 0)
        {
            // Choose a random prefab from the array
            GameObject prefabToSpawn = objectPrefabs[Random.Range(0, objectPrefabs.Length)];

            // Generate a random spawn position within the specified range
            float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
            Vector3 spawnPosition = new Vector3(randomX, spawnY, 0f);

            // Instantiate the chosen prefab at the spawn position
            if (prefabToSpawn != null)
            {
                GameObject spawnedObject = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
                Destroy(spawnedObject, 3f);
            }
            else
            {
                Debug.LogError("Prefab to spawn is null!");
            }
        }
        else
        {
            Debug.LogError("Object prefabs array is null or empty!");
        }
    }
}