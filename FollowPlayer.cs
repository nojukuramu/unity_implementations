using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; //Reference the player position
    public float speed; //This will be 0 default to inspector

    void Update()
    {
        //Use Vector2.MoveTowards to move this object to the player position. speed * deltaTime will work regardless of framerate
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
}
