using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentScript : MonoBehaviour
{
    public GameObject bulletDestroy;

   private void OnTriggerEnter2D(Collider2D other) 
    {

        if (other.tag == "Bullet")
        {
            GameObject bulletBoom = Instantiate(bulletDestroy, other.transform.position, Quaternion.identity);
            bulletBoom.GetComponent<ParticleSystem>().Play();

            Object.Destroy(other.gameObject);
        }

    }
}
