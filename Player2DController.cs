using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DController : MonoBehaviour
{  
    //ADD THIS SCRIPT TO YOUR PLAYER SPRITE
    Vector2 move;
    public float movementSpeed; //this will be default to 0. Change Value On Inspector


    // Update is called once per frame
    void Update()
    {
        //Get the values from Input Manager
        float moveX = movementSpeed * Input.GetAxisRaw("Horizontal");
        float moveY = movementSpeed * Input.GetAxisRaw("Vertical");

        //get the X and Y positions, add moveX and moveY to x and y, then put them in new Vector2 so you can put the new value to transform.position
        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
    }
}
