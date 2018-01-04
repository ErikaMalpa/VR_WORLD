using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

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
    void Start () {
        InvokeRepeating("ReduceVitals", 1, 1);
	}
	
	void ReduceVitals()
    {
        oxygen = oxygen - 20;
        OxygenBar.value = oxygen;
        HealthBar.value = health;
        if (oxygen <= 0)
        {
            health--;
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
