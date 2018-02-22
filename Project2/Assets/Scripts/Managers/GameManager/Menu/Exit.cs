using UnityEngine;

namespace Assets.Scripts.Managers.GameManager.Menu
{
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
}
