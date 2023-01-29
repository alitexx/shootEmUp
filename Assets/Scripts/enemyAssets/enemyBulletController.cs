using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletController : MonoBehaviour
{
    private Transform bulletSpawn;
    public GameObject bullet;
    public float fireTime;
    private float currentTime = 0.0f;

    void Start()
    {
        bulletSpawn = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;


        if (currentTime > fireTime)
        {
            fireTime += currentTime;

            Instantiate(bullet, bulletSpawn.position, Quaternion.identity);

            fireTime -= currentTime;
            currentTime = 0.0f;

        }
    }
}
