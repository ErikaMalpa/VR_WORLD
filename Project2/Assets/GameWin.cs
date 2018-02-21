using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour {

    //void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    Rigidbody body = hit.collider.attachedRigidbody;

    //    if (body == null || body.isKinematic) { 
    //        FindObjectOfType<GameManager>().EndGame();
    //    }
    //}

    void OnTriggerEnter(Collider other)
    {
    
        FindObjectOfType<GameManager>().EndGame();
    }
}
