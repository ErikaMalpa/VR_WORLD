using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{

    int time = 1; //10

    //Health will be 100 percent
    public static int health = 100;

    //oxygen 
    public static int oxygen = 100;

    //Slider for oxygen and health bar
    public Slider OxygenBar;
    public Slider HealthBar;

    // Use this for initialization
    /// <summary>
    /// It repeats every 1 second
    /// </summary>
    void Start()
    {
        InvokeRepeating("ReduceVitals", time, time);
    }

    void ReduceVitals()
    {
        oxygen = oxygen - 50; //5
        OxygenBar.value = oxygen;
        HealthBar.value = health;
        if (oxygen <= 0)
        {
            health = health - 30; //15
        }
        if (health <= 0)
        {
            print("You are dead");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
