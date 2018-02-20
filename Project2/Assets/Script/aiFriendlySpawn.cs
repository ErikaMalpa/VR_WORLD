using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiFriendlySpawn : MonoBehaviour {

    private float nextSpawnTime;
    private int SpawnLimit = 15;
    private int SpawnCount;

    [SerializeField]
    private GameObject Prefab;
    [SerializeField]
    private float spawnDelay = 10;

    private void Update()
    {
        if (SpawnCount <= SpawnLimit)
        {
            if (ShouldSpawn())
            {
                Spawn();
                float xp = Random.Range(0f, -100f);
                float yp = 1f;
                float zp = Random.Range(0f, 100f);
                transform.position = new Vector3(xp, yp, zp);
            }
        }

    }

    private void Spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(Prefab, transform.position, transform.rotation);
        SpawnCount++;
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
}
