using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{

    public float Damage;

    public GameObject Player;

    public GameObject playerHit;

    float time = 0;

    public float attackTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    void OnTriggerStay2D(Collider2D other) 
    {
        Debug.Log("--> OnTriggerStay2D");


        if ((other.tag == "Player") && time >= attackTimer)
        {
            GameObject playerBleed = Instantiate(playerHit, other.transform.position, Quaternion.identity);

            Player.GetComponent<PlayerController> ().currentHealth -= Damage;

            playerBleed.GetComponent<ParticleSystem>().Play();

            time = 0;
        }

    }
}
