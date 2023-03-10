using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    private Rigidbody2D bulletRB;
    private float moveSpeed = 10.0f;


    void Start()
    {
        audioManager.playerShoot();
        bulletRB = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletRB.velocity = new Vector2(0, 1) * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            audioManager.explosionSFX();
            playerController.increasePlayerPoints();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Top")
        {
            Destroy(gameObject);
        }
    }
}
