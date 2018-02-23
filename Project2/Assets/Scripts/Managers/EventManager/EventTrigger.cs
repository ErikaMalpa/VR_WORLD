using UnityEngine;
using System.Collections;

public class EventTrigger : MonoBehaviour
{


    void Update()
    {

        //if (Input.GetAxis("Mouse X"))
        //{
        //    EventManager.TriggerEvent("Spawn");
        //}

        if (Input.GetKeyDown("p"))
        {
            EventManager.TriggerEvent("Destroy");
        }

    }
}