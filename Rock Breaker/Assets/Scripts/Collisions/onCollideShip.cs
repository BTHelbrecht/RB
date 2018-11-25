/*
SHIP COLLISION SYSTEM
onCollideShip.cs
JERARD CARNEY
NOVEMBER.24.2018
*/

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Class Public >> onCollideShip >> MonoBehaviour
public class onCollideShip : MonoBehaviour {

// Public Variables
    // Force needed to destroy ship on collide
    public float integridyLimit;
    // Variable to hold counter value for lives
    public int lives;
    // Vaariable to hold text box lives
    public Text livesText;



    // Use this for initialization
    void Start ()
    {
        livesText.text = "LIVES: " + lives;
	}
	


	// Update is called once per frame
	void Update ()
    {
		
	}



    // Updates is called when two non-trigger colliders collide
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug to test collision
        Debug.Log("Hit" + collision.relativeVelocity);
        // Condition >> if another gameobject has enough velocity greater then ships limit
        if(collision.relativeVelocity.magnitude > integridyLimit)
        {
            // Debug to test limits
            Debug.Log("DIE");
            // Lives drop down by 1
            lives--;
            livesText.text = "LIVES: " + lives;
            // Destroy the ship
            Destroy(gameObject);
        }

        // Condition >> if cause death and live are reduced to 0 >> GAME OVER
        if(lives <= 0)
        {

        }
    }
}
