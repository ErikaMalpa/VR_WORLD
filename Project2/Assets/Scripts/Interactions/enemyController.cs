using Assets.Scripts.Managers.PlayerManager;
using UnityEngine;

namespace Assets.Scripts
{
    /// <inheritdoc />
    /// <summary>
    /// This is the controller of the enemy, animations will be played based on the position of the player
    /// If the player is close it will Float to the player and if the player is really close
    /// it will attack
    /// If player is far away, it will be idle
    /// </summary>
    public class enemyController : MonoBehaviour
    {

        public Transform Player;
        static Animator _animator;
        //Health will be 100 percent
        public static int Health = 100;

        // Use this for initialization
        //returns the component of Type type if the game object has one attached
        void Start()
        {
            _animator = GetComponent<Animator>();
        }

        //Collider for the enemy
        private void OnTriggerEnter(Collider other)
        {
            Health = Health - 10;
            PlayerManager.Health = PlayerManager.Health - 5;
            Debug.Log("You have been hit!");
        }


        // Update is called once per frame
        /// <summary>
        /// Test for the distance between the players poistion and the ai position
        /// if less than 10 
        /// we will work out the direction from the player to the skeleton
        /// and then use the direction vector (player between ai),
        /// Ai will rotate towards the direction
        /// </summary>
        void Update()
        {

            if (Vector3.Distance(Player.position, this.transform.position) < 10)
            {
                Vector3 direction = Player.position - this.transform.position;
                //remove y so that iw will not rotate upwards
                direction.y = 0;

                //Slerp slowly move
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

                //isFloating is set active
                _animator.SetBool("isIdle", false);

                //If direction vector (magnitude - length of a vector) 
                //if its greater than 5, we will translate in z direction
                //Basically making z as the forward direction

                if (direction.magnitude > 5)
                {
                    this.transform.Translate(0, 0, 0.05f);
                    _animator.SetBool("isAttacking", false);
                    _animator.SetBool("isFloating", true);
                }
                else
                {
                    _animator.SetBool("isAttacking", true);
                    _animator.SetBool("isFloating", false);

                }
            }
            else
            {
                _animator.SetBool("isIdle", true);
                _animator.SetBool("isFloating", false);
                _animator.SetBool("isAttacking", false);
            }

            if (Health <= 0)
            {
                Destroy(gameObject);
            }
        }


    }
}
