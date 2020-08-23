using UnityEngine;

public class ZombieHealthScript : MonoBehaviour
{

    public float health = 100f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }


    void OnCollisionEnter(Collision collision)
    {
        
         if (collision.gameObject.tag == "Bullet")
         {

             Debug.Log("Bullet Hit Zombie.");

         }

    }



}
