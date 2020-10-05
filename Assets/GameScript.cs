﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{

    float time = 0f;

    public GameObject basicZombie;

    public GameObject fastZombie;

    public GameObject strongZombie;

    float random;

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
            
            random = Random.Range(1, 9);
            Debug.Log(random);

            //If statment for the normal zombie.

            if (random == 1 || random == 2 || random == 3 || random == 4)
            {
                GameObject clone = Instantiate(basicZombie, new Vector3(Random.Range(-22, 32), Random.Range(8, -18)), basicZombie.transform.rotation);
                clone.SetActive(true);
            }

            //If statment for the fast zombie.

            else if(random == 5 || random == 6)
            {
                GameObject clone = Instantiate(fastZombie, new Vector3(Random.Range(-22, 32), Random.Range(8, -18)), fastZombie.transform.rotation);
                clone.SetActive(true);
            }

            //If statment for the strong zombie.

            else if(random == 7 || random == 8)
            {
                GameObject clone = Instantiate(strongZombie, new Vector3(Random.Range(-22, 32), Random.Range(8, -18)), strongZombie.transform.rotation);
                clone.SetActive(true);
            }

            time = 0;
        }
    }
}
