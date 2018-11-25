/*
BULLET COLLISION SYSTEM
onCollideBullet.cs
JERARD CARNEY
NOVEMBER.24.2018
*/

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Class Public onCollideBullet >> MonoBehaviour
public class onCollideBullet : MonoBehaviour {

// Public Variables
    // Variable to state points for hits
    public int pointWorth;
    // Variable to link to the scoring script/gameobject
    public GameObject scoringObject;


    // Use this for initialization
    void Start ()
    {
        // ID player
        GameObject.FindWithTag("User");
	}
	



	// Update is called once per frame
	void Update ()
    {
		
	}



    // Update called on trigger event, Ment for bullet collision with asteroid
    void OnTriggerEnter2D(Collider2D other)
    {
        // Debug Log to see if bullet registered as a hit with asteroid
        Debug.Log("Hit by " + other.name);
        // Destroyes bullet clone once hit is triggered
        Destroy(other.gameObject);
        // Score points by telling scoring script points are earned
        scoringObject.SendMessage("PointCounter", pointWorth);
        // Destroy asteroid
        Destroy(gameObject);
    }
}
