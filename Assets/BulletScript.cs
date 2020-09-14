using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 12f;

    // These will be upgradable: 
    public float damage = 10f;
    public float range = 10f;
    public float shootSpeed = 0.2f;
    public float reloadTime = 2f;
    float timer = 0f;

    public float bulletLifeTime = 2.7f;

    public GameObject bulletDestroy;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.up * Time.deltaTime * speed;
        timer += Time.deltaTime;

        if (timer >= bulletLifeTime)
        {
            GameObject bulletBoom = Instantiate(bulletDestroy, this.transform.position, Quaternion.identity);
            bulletBoom.GetComponent<ParticleSystem>().Play();

            Object.Destroy(this.transform.gameObject);

        }
    }
}
