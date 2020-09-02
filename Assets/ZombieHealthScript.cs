﻿using UnityEngine;

public class ZombieHealthScript : MonoBehaviour
{
    public float health = 100f;

    public GameObject explosion;

    public GameObject hitExplosion;

    public AudioSource dead;
    public AudioSource hit;
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Bullet")
        {
            health -= other.GetComponent<BulletScript> ().damage;
            
            GameObject hitBoom = Instantiate(hitExplosion, other.transform.position, Quaternion.identity);
            hitBoom.GetComponent<ParticleSystem>().Play();

            hit.Play();

            Object.Destroy(other.gameObject);

            if (health <=0)
            {
                GameObject boom = Instantiate(explosion, this.transform.position, Quaternion.identity);
                AudioSource death = Instantiate(dead, this.transform.position, Quaternion.identity);
                death.Play();
                boom.GetComponent<ParticleSystem>().Play();
                Object.Destroy(this.transform.parent.gameObject);
            }

        }
    }
}




