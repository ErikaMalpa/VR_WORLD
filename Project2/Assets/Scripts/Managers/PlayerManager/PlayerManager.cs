﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

/// <summary>
/// This class will control the health and oxygen of the player, We use Invoke repeating 
/// to constantly reduce the players health and oxygen at a certain time (5)
/// </summary>
public class PlayerManager : MonoBehaviour
{
    //The time added
    int time = 5;

    //Health will be 100 percent
    public static int health = 100;

    //oxygen will be 100 percent
    public static int oxygen = 100;

    //Slider for oxygen and health bar
    public Slider OxygenBar;
    public Slider HealthBar;

    // Use this for initialization
    /// <summary>
    /// Invokes the method ReduceVitals in time seconds, then repeatedly every repeatRate seconds.
    /// Starting in 5 seconds, oxygen will be reduced every 5 seconds
    /// </summary>
    void Start()
    {
        InvokeRepeating("ReduceVitals", time, time);
    }

    /// <summary>
    /// This will redice vitals, oxygen will decrement by 5
    /// If oxygen is less than or equal to zero then the health will be decremented by 15
    /// When health is less than or equal to zero, the player will restart the level
    /// </summary>
    void ReduceVitals()
    {
        oxygen = oxygen - 5; //5
        OxygenBar.value = oxygen;
        HealthBar.value = health;
        if (oxygen <= 0)
        {
            health = health - 15; //15
        }
        if (health <= 0)
        {
            Debug.Log("You are Dead");
            Application.LoadLevel("MainScreen");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
