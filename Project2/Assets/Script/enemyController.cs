using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{

    public Transform player;
    static Animator anim;
    //Health will be 100 percent
    public static int health = 100;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //health = health - 100;
    }


    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(player.position, this.transform.position) < 10)
        {
            Vector3 direction = player.position - this.transform.position;
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            anim.SetBool("isIdle", false);
            if(direction.magnitude > 5)
            {
                this.transform.Translate(0, 0, 0.05f);
                anim.SetBool("isAttacking", false);
                anim.SetBool("isFloating", true);
            }
            else
            {
                anim.SetBool("isAttacking", true);
                anim.SetBool("isFloating", false);
                //PlayerManager.health = PlayerManager.health  - 1;
            }
        }
        else
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isFloating", false);
            anim.SetBool("isAttacking", false);
        }

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }


}