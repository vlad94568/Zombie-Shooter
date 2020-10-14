using UnityEngine;

public class ZombieHealthScript : MonoBehaviour
{
    public float health = 100f;

    public GameObject explosion;

    public GameObject hitExplosion;

    public AudioSource dead;

    public AudioSource hit;

    public GameObject scoreObject;

    public float scoreAmount;

    float lastHealth;

    float timer = 0;

    public GameObject pathfinding;

    public GameObject gameManager;

    float speed;
    
    void Start()
    {
        lastHealth = health;

        speed = pathfinding.GetComponent<Pathfinding.AIPath>().maxSpeed;
    }


    void Update()
    {

        if (lastHealth > health)
        {

            timer += Time.deltaTime;

            pathfinding.GetComponent<Pathfinding.AIPath>().maxSpeed = 1.5f;

            pathfinding.transform.rotation = Random.rotation;

            if (timer >= 0.1)
            {
                timer = 0;

                lastHealth = health;

                pathfinding.GetComponent<Pathfinding.AIPath>().maxSpeed = speed;

            }


        }
    }


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

                gameManager.GetComponent<GameScript> ().zombiesAlive -= 1;

                GameObject boom = Instantiate(explosion, this.transform.position, Quaternion.identity);
                AudioSource death = Instantiate(dead, this.transform.position, Quaternion.identity);
                death.Play();
                boom.GetComponent<ParticleSystem>().Play();

                ScoreScript scoreScript = scoreObject.GetComponent<ScoreScript>();
                scoreScript.score += scoreAmount;

                Object.Destroy(this.transform.parent.gameObject);
            }

        }
    }
}




