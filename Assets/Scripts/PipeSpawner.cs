using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // Section in inspector to add the prefab.
    public GameObject pipePrefab;

    // Range of pipes height spawn.
    public float heightRange = 0.5f;

    // Spawn time.
    public float maxTime = 1.75f;

    // Timer for spawn time (maxTime).
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    public void SpawnPipe()
    {
        // Vector3 variable to save new random height for next spawn.
        Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));

        // New game object.
        GameObject newPipe;

        // Data for new game object (what is it?, position?).
        newPipe = Instantiate(pipePrefab, spawnPosition, Quaternion.identity);

        Destroy(newPipe, 10f);
    }
}
