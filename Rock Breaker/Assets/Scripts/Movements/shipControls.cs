/*
SHIPCONTROLS
shipControls.cs
JERARD CARNEY
NOVEMBER.24.2018
*/

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// shipControls class >> MonoBehavior
public class shipControls : MonoBehaviour {

//Variables Public
    // Access to ships rigidy body
    public Rigidbody2D body;
    // Straight thrust amount
    public float straightThrust;
    // Rotation thrust amount
    public float turnThrust;


//Variables Private
    // Straight thrust input
    private float straightInput;
    // Turn thrust input
    private float turnInput;



    // Use this for initialization
    void Start ()
    {
		// None
	}
	



	// Update is called once per frame
	void Update ()
    {
        // check for user input...
        straightInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
    }



    // Updated of fixed time interval (similaur to update in theory)
    void FixedUpdate()
    {
        // Ship pointing forward on y-Axis force applied only on y to move ship, * thrust for control of movement
        body.AddRelativeForce(Vector2.up * straightInput);
        // Add teurn torque on z-Axis, (Inverted)
        body.AddTorque(-turnInput);

    }
}
