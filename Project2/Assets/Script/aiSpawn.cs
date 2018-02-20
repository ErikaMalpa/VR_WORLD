using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This will spawn the AI in the game at a random location
/// </summary>
public class aiSpawn : MonoBehaviour {

    //When our next character will spawn
    private float spawnTime;
    //Limit the spawn to 15
    private int SpawnLimit = 15;
    private int SpawnCount;

    //Where you put your prefab charachter 
    [SerializeField]
    private GameObject characterPrefab;
    //It will spawn every 10 seconds
    [SerializeField]
    private float spawnDelay = 10;

    /// <summary>
    /// if the spawn count is lest than or equal to the limit
    /// It will spawn the object in the location that was chosen
    /// </summary>
    private void Update()
    {
        if(SpawnCount <= SpawnLimit)
        {
            if (Spawning())
            {
                Spawn();
                float xp = Random.Range(0f, -100f);
                float yp = 1f;
                float zp = Random.Range(0f, 100f);
                transform.position = new Vector3(xp, yp, zp);
            }
        }
        
    }
    /// <summary>
    /// We set the spawn time with current time plus the delay
    /// We call the instantiate and it will spawn the object with the position and rotation
    /// Spawn count incremented
    /// </summary>
    private void Spawn()
    {
        spawnTime = Time.time + spawnDelay;
        Instantiate(characterPrefab, transform.position, transform.rotation);
        SpawnCount++;
    }

    /// <summary>
    /// Boolean for spawning
    /// </summary>
    /// <returns>if current time is greater than the next spawn time</returns>
    private bool Spawning()
    {
        return Time.time >= spawnTime;
    }
}
