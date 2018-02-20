using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class adds 10 to the players health level
/// health is imported from the player manager
/// When the player comes near the object, it will then be destroyed
/// </summary>
public class HealthPotion : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        PlayerManager.health = PlayerManager.health + 10;
        Debug.Log("Added 10 health");
        Destroy(this.gameObject);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
