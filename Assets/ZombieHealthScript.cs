using UnityEngine;

public class ZombieHealthScript : MonoBehaviour
{
    public float health = 100f;

    public GameObject explosion;

    public AudioSource dead;
    public AudioSource hit;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Bullet")
        {
            health -= other.GetComponent<BulletScript> ().damage;

            hit.Play();

            Object.Destroy(other.gameObject);

            if (health <=0)
            {
                GameObject boom = Instantiate(explosion, this.transform.position, Quaternion.identity);
                dead.Play();
                boom.GetComponent<ParticleSystem>().Play();
                Object.Destroy(this.gameObject);
            }

        }
    }
}




