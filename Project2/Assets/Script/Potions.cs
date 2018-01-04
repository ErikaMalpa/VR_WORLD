using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potions : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        PlayerManager.oxygen += 25;
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
