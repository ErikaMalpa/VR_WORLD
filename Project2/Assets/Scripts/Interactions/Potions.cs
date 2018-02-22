using Assets.Scripts.Managers.PlayerManager;
using UnityEngine;

namespace Assets.Scripts.Interactions
{
    /// <summary>
    /// This will add 25 oxygen to the players oxygen 
    /// </summary>
    public class Potions : MonoBehaviour {

        private void OnTriggerEnter(Collider other)
        {
            PlayerManager.Oxygen += 25;
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
}
