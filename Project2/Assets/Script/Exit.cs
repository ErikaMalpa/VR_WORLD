using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// When the Quit game is pressed, the game will exit itself
/// </summary>
public class Exit : MonoBehaviour {


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exit");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
