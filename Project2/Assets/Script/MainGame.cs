using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This will load the main game scene when let's play button is pressed in the main menu
/// </summary>
public class MainGame : MonoBehaviour {

	public void letsPlayBtn (string mainGame)
    {
        SceneManager.LoadScene(mainGame);
    }
}
