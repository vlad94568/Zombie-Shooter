using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{

    float time = 0f;

    public Transform basicZombie;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 5)
        {
            Instantiate(basicZombie, new Vector3(Random.Range(-22, 32), Random.Range(8, -18)), basicZombie.rotation);
            time = 0;
        }
    }
}
