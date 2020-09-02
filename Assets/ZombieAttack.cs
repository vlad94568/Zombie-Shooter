using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{

    public float Damage;

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
            Debug.Log("--> OnTriggerEnter2D");
            
            Player.GetComponent<PlayerController> ().currentHealth -= Damage;
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        Debug.Log("--> OnTriggerExit2D");
    }

    void OnTriggerStay2D(Collider2D other) 
    {
        Debug.Log("--> OnTriggerStay2D");
    }
}
