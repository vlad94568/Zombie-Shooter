using UnityEngine;

public class ZombieHealthScript : MonoBehaviour
{

    public float health = 100f;

    private void OnTriggerEnter2D(Collider2D other) 
    {

        if (other.tag == "Bullet")
        {
            Object.Destroy(this.gameObject);
            Object.Destroy(other.gameObject);
        }

    }




}




