using UnityEngine;

public class GunScript : MonoBehaviour
{

    public Transform bullet;
    public Transform bulletLaunch;

    //Sound
    public AudioSource shootSound;


    //Upgrade
    public float bulletsPerShoot = 1f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

            shootSound.Play();
            Instantiate(bullet, new Vector3(bulletLaunch.position.x, bulletLaunch.position.y, bulletLaunch.position.z), bulletLaunch.rotation);

        }
        
    }
}
