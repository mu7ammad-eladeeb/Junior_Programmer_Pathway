using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    // Array of animal prefabs to spawn
    public GameObject[] animalPrefabs;
    // Input action for spawning animals
    public InputAction spawnAction; 
    // Range for spawning animals on the X-axis
    public float spawnRangeX = 20;
    // Fixed spawn position on the Z-axis
    public float startDelay = 2.0f; // Delay before the first spawn
    public float spawnInterval = 3f; // Interval between spawns
    public float spawnPosZ = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnAction.Enable(); // Enable the input action
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the spawn action is triggered
        
    }
    void SpawnRandomAnimal()
    {
        // Generate a random spawn position within the specified range
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        // Select a random animal prefab from the array
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // Instantiate the selected animal prefab at the generated spawn position with its default rotation
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
