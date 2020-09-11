﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed = 12f;

    public float currentHealth = 100f;

    public Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Move this to when the player takes damage.
        healthBar.value = currentHealth;

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        this.transform.position = new Vector3(transform.position.x + (x * speed * Time.deltaTime), transform.position.y + (y * speed * Time.deltaTime), transform.position.z);

        if (healthBar.value <= 0)
        {   
            // TODO make a new scene where the player died.

            Debug.Log("The Player is DEAD, GAME OVER");
        }
    }
}
