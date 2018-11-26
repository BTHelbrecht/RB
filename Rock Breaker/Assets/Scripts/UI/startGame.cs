/*
START GAME
startGame.cs
JERARD CARNEY
NOVEMBER.24.2018
*/

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Class Public >> startGame >> Mon0Behaviour
public class startGame : MonoBehaviour {

	// Use this for initialization
	public void StartGame()
    {
        // Load menu scene
        SceneManager.LoadScene("rockBreaker");
    }
}
