using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Managers.GameManager.Menu
{
    public class MainGame : MonoBehaviour {

        public void LetsPlayBtn (string mainGame)
        {
            SceneManager.LoadScene(mainGame);
        }
    }
}
