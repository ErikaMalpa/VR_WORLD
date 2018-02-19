﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{

    public Transform player;
    static Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
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
            if(direction.magnitude > 2)
            {
                this.transform.Translate(0, 0, 0.05f);
                anim.SetBool("isWaling", true);
                anim.SetBool("isAttacking", false);
            }
            else
            {
                anim.SetBool("isAttacking", true);
                anim.SetBool("isWaling", false);
                PlayerManager.health = PlayerManager.health - 5;
            }
        }
        else
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isWaling", false);
            anim.SetBool("isAttacking", true);
        }
    }
}