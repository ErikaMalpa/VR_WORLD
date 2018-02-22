using Assets.Scripts.Managers.PlayerManager;
using UnityEngine;

namespace Assets.Scripts.Interactions
{
    /// <summary>
    /// This will add 15 health to the players health
    /// </summary>
    public class HealthPotion : MonoBehaviour {

        private void OnTriggerEnter(Collider other)
        {
            PlayerManager.Health += 15;
            Debug.Log("Added 15 health");
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
