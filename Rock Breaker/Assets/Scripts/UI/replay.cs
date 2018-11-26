/*
REPLAY SYSTEM
replay.cs
JERARD CARNEY
NOVEMBER.24.2018
*/

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// Class Public >> replay >> MonoBehaviour
public class replay : MonoBehaviour {



	// Use this for initialization
	void Start ()
    {
		
	}
	



	// Update is called once per frame
	void Update ()
    {
		
	}



    // Replay button function
    public void Replay()
    {
        // Loads game scene
        SceneManager.LoadScene("rockBreaker");
    }



    // Start menu function
    public void Menu()
    {
        // Loads start menu
        SceneManager.LoadScene("startMenu");
    }
}
