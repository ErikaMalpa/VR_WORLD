using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class adds 25 to the players oxygen level
/// ocygen is imported from the player manager
/// When the player comes near the object, it will then be destroyed
/// </summary>
public class Potions : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        PlayerManager.oxygen = PlayerManager.oxygen + 25;
        Debug.Log("Added 25 oxygen");
        Destroy(this.gameObject);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
