/*
POINT SCORING SYSTEM
scoring.cs
JERARD CARNEY
NOVEMBER.24.2018
*/

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Class Public >> scouring >> MonoBehaviour
public class scoring : MonoBehaviour {

// Public Variables
    // Variable for text box score
    public Text scoreText;
    // Game over panel game object
    public GameObject GameOver_P;


    // Private Variables
    // Variable int to hold score
    private int score;




	// Use this for initialization
	void Start ()
    {
        // Initial scare, hard code = 0
        score = 0;
        // Put score into scroe box
        scoreText.text = "SCORE: " + score;
	}
	


	// Update is called once per frame
	void Update ()
    {
		
	}



    // Updates when asteroid is destroyed via bullet collisions
    void PointCounter(int pointsRecieved)
    {
        // Updates the score by the points earened from the asteriod
        score += pointsRecieved;
        // Put score into scroe box
        scoreText.text = "SCORE: " + score;

        // Win Condition
        if (score == 18)
        {
            // Displays game over menu
            GameOver_P.SetActive(true);
        }
    }
}
