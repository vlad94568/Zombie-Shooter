using UnityEngine;

public class GunScript : MonoBehaviour
{
    public Transform bullet;
    public Transform bulletLaunch;

    //Sound
    public AudioSource shootSound;


    //Upgrade
    public float bulletsPerShoot = 1f;


    public float timer;

    public float Delay = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if(Input.GetMouseButtonDown(0))
        {

            if (timer >= Delay)
            {
                timer = 0;

                shootSound.Play();
                Instantiate(bullet, new Vector3(bulletLaunch.position.x, bulletLaunch.position.y, bulletLaunch.position.z), bulletLaunch.rotation);
            }

        }
        
    }
}
