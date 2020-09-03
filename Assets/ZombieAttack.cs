using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{

    public float Damage;

    public GameObject Player;

    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
            Debug.Log("--> OnTriggerEnter2D");
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        Debug.Log("--> OnTriggerExit2D");
    }

    void OnTriggerStay2D(Collider2D other) 
    {
        Debug.Log("--> OnTriggerStay2D");


        if ((other.tag == "Player") && time >= 1)
        {
            Player.GetComponent<PlayerController> ().currentHealth -= Damage;
            time = 0;
        }

    }
}
