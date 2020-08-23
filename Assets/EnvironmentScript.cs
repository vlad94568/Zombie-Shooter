using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentScript : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) 
    {

        if (other.tag == "Bullet")
        {
            Object.Destroy(other.gameObject);
        }

    }
}
