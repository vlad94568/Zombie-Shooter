using UnityEngine;

public class GunScript : MonoBehaviour
{

    public Transform bullet;
    public Transform bulletLaunch;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        Instantiate(bullet, new Vector3(bulletLaunch.position.x, bulletLaunch.position.y, bulletLaunch.position.z), bulletLaunch.rotation);
        
    }
}
