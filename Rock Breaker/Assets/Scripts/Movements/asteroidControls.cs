/*
SHIPSOOTING
sgooting.cs
JERARD CARNEY
NOVEMBER.24.2018
*/

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Class asteroidControl >> MonoBehavior
public class asteroidControls : MonoBehaviour
{

    public float maxThrust;
    public float maxSpin;
    public Rigidbody2D body;

    // Use this for initialization
    void Start()
    {
        // Add spin/thrust to asteroid
        // Generate a vector2 and place a random float in x/y-Axis
        Vector2 thrust = new Vector2(Random.Range(-maxThrust, maxThrust), Random.Range(-maxThrust, maxThrust));
        // Generate random number for spin
        float spin = Random.Range(-maxThrust, maxThrust);


        // Add thrust to asteroid
        body.AddForce(thrust);
        // Add spin to asteroid
        body.AddTorque(spin);
    }

    // Update is called once per frame
    void Update()
    {

    }
}