using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGame : MonoBehaviour {

	public void letsPlayBtn (string mainGame)
    {
        SceneManager.LoadScene(mainGame);
    }
}
