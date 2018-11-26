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
    // Access to ship Rigidbody
    public Rigidbody2D body;
    // Original art ship
    public Sprite originalArt;
    // Clean respawn alt. art ship
    public Sprite respawnArt;
    // Game over panel game object
    public GameObject GameOver_P;



    // Use this for initialization
    void Start ()
    {
        livesText.text = "LIVES: " + lives;
	}
	


	// Update is called once per frame
	void Update ()
    {
		
	}



    // Updates when ship is dead for 3 seconds, repawn
    void Respawn()
    {
        // stops the ships movement
        body.velocity = Vector2.zero;
        // Sets ship location x/y-Axis to 0
        transform.position = Vector2.zero;

        // Gets the sprite renderer and sets to alt art to show it is safe against collisions
        SpriteRenderer shipRender = GetComponent<SpriteRenderer>();
        shipRender.enabled = true;
        shipRender.sprite = respawnArt;


        // Call clean respawn function to not die from spawn on asteroids
        Invoke("CleanRespawn", 5f);
       
    }

    void CleanRespawn()
    {
        GetComponent<Collider2D>().enabled = true;
        GetComponent<SpriteRenderer>().sprite = originalArt;
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
            // disables the ships collider and renderer for death porpuses
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            // After 3 seconds call respawn function
            Invoke("Respawn", 1.5f);
        }

        // Condition >> if cause death and live are reduced to 0 >> GAME OVER
        if(lives <= 0)
        {
            // Destroys the ship
            CancelInvoke();
            // Displays game over menu
            GameOver_P.SetActive(true);

        }
    }
}
