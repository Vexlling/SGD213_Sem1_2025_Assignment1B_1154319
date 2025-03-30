using UnityEngine;
using System.Collections;

public class SpawnRateScript : MonoBehaviour
{

    // Object to spawn
    [SerializeField]
    private GameObject spawnObject;

    // Delay between spawns
    [SerializeField]
    private float spawnDelay = 2f;

    private Renderer spawnRenderer;

    // Use this for initialization
    void Start()
    {
        spawnRenderer = GetComponent<Renderer>();

        // Stop our Spawner from being visible!
        spawnRenderer.enabled = false;

        // Call the given function after spawnDelay seconds, 
        // and then repeatedly call it after spawnDelay seconds.
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }

    void Spawn()
    {
        float x1 = transform.position.x - spawnRenderer.bounds.size.x / 2;

        float x2 = transform.position.x + spawnRenderer.bounds.size.x / 2;

        // Randomly pick a point within the spawn object
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        // Spawn the object at the 'spawnPoint' position
        Instantiate(spawnObject, spawnPoint, Quaternion.identity);
    }
}
