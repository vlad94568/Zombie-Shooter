using UnityEngine;
using UnityEngine.UI;

public class EnemieHealthBarScript : MonoBehaviour
{

    Transform zombie;

    Transform zombieSprite;

    public float offset;


    // Start is called before the first frame update
    void Start()
    {
        zombie = this.transform.parent.parent;
        zombieSprite = this.transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Quaternion.Euler(0,0,0);
        this.transform.position = new Vector3(zombie.transform.position.x, zombie.transform.position.y + offset, zombie.transform.position.z);

        this.GetComponentInChildren<Slider>().value = zombieSprite.GetComponent<ZombieHealthScript>().health;
    }
}
