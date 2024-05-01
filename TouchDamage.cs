using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDamage : MonoBehaviour
{   
    //!!!! MAKE SURE YOUR OBJECTS HAS COLLIDERS TO DETECT COLLISIONS!!!! //
    //this code assumes you are using my other Health.cs script that I have created.

    public float damageAmount; // default to 0. change this on inspector

    void OnCollisionStay2D(Collision2D collision) {
        GameObject coll = collision.gameObject;
        coll.GetComponent<Health>().TakeDamage(damageAmount); //if you are using your own script for Health System, change this line
    }
