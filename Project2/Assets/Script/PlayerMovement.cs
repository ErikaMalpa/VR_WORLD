using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float playerSpeed;

	// Use this for initialization
	void Start () {
        playerSpeed = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(playerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f,playerSpeed *  Input.GetAxis("Vertical") * Time.deltaTime);
	}
}
