using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friendlySpawner : MonoBehaviour {

    private GameObject friendlySpawn;
    public GameObject[] friendlyType;
    public int maxFriendly = 10;
    public int maxFriendlyinMem = 30;

    List<GameObject> friendlies;
    public static int numFriendlies;

    private int spawnRange = 100;
    private int minSpawnRange = -100;
    private int friendlySwitch;

    void Start()
    {
        friendlySwitch = 0;
        numFriendlies = 0;
        friendlies = new List<GameObject>();
        for(int i = 0; i < maxFriendlyinMem; i++)
        {
            GameObject obj = (GameObject)Instantiate(GetFriendlies());
            obj.SetActive(false);
            friendlies.Add(obj);
            friendlySwitch += 1;
            if(friendlySwitch > 2)
            {
                friendlySwitch = 1;
            }
        }
    }

    void Update()
    {
        while(numFriendlies < maxFriendly)
        {
            SpawnFriendlies();

        }
    }

    void SpawnFriendlies()
    {
        Vector3 spawnLocation = Random.insideUnitSphere * spawnRange;

        Vector3 finalLocation = new Vector3(spawnLocation.x, 0, spawnLocation.z);

        if(float.IsInfinity(finalLocation.x) || float.IsInfinity(finalLocation.y) || float.IsInfinity(finalLocation.z))
        {
            finalLocation = new Vector3(5, 0, 20);
        }

        if (numFriendlies < maxFriendly)
        {
            for (int i = 0; i < friendlies.Count; i++)
            {
                if(!friendlies[i].activeInHierarchy)
                {
                    friendlies[i].transform.position = finalLocation;
                    friendlies[i].transform.rotation = Quaternion.identity;
                    friendlies[i].SetActive(true);
                    numFriendlies += 1;

                    break;
                }
            }
        }
    }

    GameObject GetFriendlies()
    {
        switch (friendlySwitch)
        {
            case 1:
                friendlySpawn = friendlyType[1];
                break;
            case 2:
                friendlySpawn = friendlyType[2];
                break;
            default:
                friendlySpawn = friendlyType[0];
                break;
        }
        return friendlySpawn;
    }
}
