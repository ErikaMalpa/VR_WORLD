using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

namespace Assets.Scripts.Managers.GameManager.Menu
{
    public class PauseGame : MonoBehaviour
    {

        public Transform Canvas;
        public Transform Player;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                Pause();
            }
        }

        public void Pause()
        {
            if (Canvas.gameObject.activeInHierarchy == false)
            {
                Canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
                Player.GetComponent<FirstPersonController>().enabled = false;
            }
            else
            {
                Canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
                Player.GetComponent<FirstPersonController>().enabled = true;
            }
        }
    }
}
