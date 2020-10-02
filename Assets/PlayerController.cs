using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //
    // Public members.
    //

    public float speed = 12f;

    public float currentHealth = 100f;

    public Slider healthBar;

    //
    // Private members.
    //

    float lastHealth;

    float colorChangeTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        lastHealth = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        colorChangeTimer += Time.deltaTime;

        // Move this to when the player takes damage.
        healthBar.value = currentHealth;

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        this.transform.position = new Vector3(transform.position.x + (x * speed * Time.deltaTime), transform.position.y + (y * speed * Time.deltaTime), transform.position.z);

        if (healthBar.value <= 0)
        {   
            // TODO make a new scene where the player died.
            Debug.Log("The Player is DEAD, GAME OVER");
        }

        if (currentHealth < lastHealth)
        {
            // Reset the last health.
            lastHealth = currentHealth;

            // Change to red.
            GetComponent<SpriteRenderer>().color = new Color(1f,0.30196078f, 0.30196078f);

            // Restart color change timer.
            colorChangeTimer = 0f;
        }

        if (colorChangeTimer > 0.3) // Timer ellpased for color change...
        {
            colorChangeTimer = 0f; 

            // Change to white.
            GetComponent<SpriteRenderer>().color = new Color(255f,255f, 255f);
        }
    }
}
