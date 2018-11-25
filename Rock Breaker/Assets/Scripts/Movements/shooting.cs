/*
SHIPSOOTING
shooting.cs
JERARD CARNEY
NOVEMBER.24.2018
*/

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class shooting >> MonoBehavior
public class shooting : MonoBehaviour
{

    // Public Variables
    // Access to ships rigidy body
    public Rigidbody2D body;
    // Game object for bullet
    public GameObject bullet;
    // Bullet force
    public float bulletForce;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Check for input from space for Fire
        if (Input.GetButtonDown("Shoot"))
        {
            // Shoots bullet into the direction ship rigidbody is facing
            GameObject createdBullet = Instantiate(bullet, transform.position, transform.rotation);
            // Adds force to bullet
            createdBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * bulletForce);
            // Removes bullet after 5sec so game isn't encumbered
            Destroy(createdBullet, 5.0f);
        }
    }
}
