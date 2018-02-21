using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

    //
    public static PlayerManager instance = null;

    //
    public int time = 10;

    //Health will be 100 percent
    public static int health = 100;

    //oxygen 
    public static int oxygen = 100;

    //Slider for oxygen and health bar
    public Slider HealthBar;
    public Slider OxygenBar;

    // Use this for initialization
    /// <summary>
    /// It repeats every 1 second
    /// </summary>
    void Awake () {
        if (instance != null && instance != this)
            Destroy(gameObject);    // Ensures that there aren't multiple Singletons

        instance = this;
        PlayerManager.instance.InvokeRepeating("Vitals", time, time);
	}
	
	public class Vitals
    {

        void reduceVitals()
        {
            oxygen = oxygen - 5;
            PlayerManager.instance.OxygenBar.value = oxygen;
            PlayerManager.instance.HealthBar.value = health;
            if (oxygen <= 0)
            {
                health = health - 15;
            }
            if (health <= 0)
            {
                print("You are dead");
            }
        }
    }
}
