using UnityEngine;

public class ZombieHealthScript : MonoBehaviour
{
    public float health = 100f;

    public GameObject explosion;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Bullet")
        {
            GameObject boom = Instantiate(explosion, this.transform.position, Quaternion.identity);
            
            boom.GetComponent<ParticleSystem>().Play();

            Object.Destroy(this.gameObject);            
            Object.Destroy(other.gameObject);
        }
    }
}




