using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{   
    public float maxHealth; //0 is default. change it on inspector


    float currentHealth; //you need current health ofcourse
    bool isDead = false; //detect if your dead or not

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0) {
            isDead = true;
        }

        if (isDead) {
            Destroy(gameObject); //this will destroy the object attached. Delete this line if you dont want to break your character
            //ADD MORE LINE HERE TO HANDLE DEATH
        }

        Debug.Log("Object: " + gameObject.name + "Health: " + currentHealth);
    }

    //lets add this code so you can take damage by calling this function
    public void TakeDamage(float damage) {
        currentHealth -= damage;
    }
}
