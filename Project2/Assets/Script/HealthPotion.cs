using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
