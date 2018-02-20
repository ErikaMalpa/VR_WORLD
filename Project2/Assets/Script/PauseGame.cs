using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

/// <summary>
/// This will pause the game when player presses b
/// </summary>
public class PauseGame : MonoBehaviour
{
    //to put the Canvas
    public Transform canvas;
    //to put the Player
    public Transform Player;

    /// <summary>
    /// if B is pressed it will pause
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Pause();
        }
    }

    /// <summary>
    /// if the canvas is not active in hierarchy then we will set it active
    /// and the ingame time will pause and the player will be unable to move
    /// else
    /// it will be a normal game and it will hide the menu
    /// </summary>
    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            Player.GetComponent<FirstPersonController>().enabled = false;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            Player.GetComponent<FirstPersonController>().enabled = true;
        }
    }
}
