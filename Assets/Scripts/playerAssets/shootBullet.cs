using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBullet : MonoBehaviour
{
    private Transform bulletSpawn;
    public GameObject bullet;
    private float debounce = 0.5f;
    private float currentTime = 0.0f;

    void Start()
    {
        bulletSpawn = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;


        if (Input.GetButton("Jump") && currentTime > debounce)
        {
            debounce += currentTime;

            Instantiate(bullet, bulletSpawn.position, Quaternion.identity);

            debounce -= currentTime;
            currentTime = 0.0f;

        }
    }


}
