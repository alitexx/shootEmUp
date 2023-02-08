using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    private Rigidbody2D enemyRB;
    [SerializeField] Canvas loseGUI;
    private bool changeDirection = false;
    public float moveSpeed;
    private GameObject enemiesFolder;

    void Start()
    {
        enemyRB = gameObject.GetComponent<Rigidbody2D>();
        enemiesFolder = GameObject.Find("enemies");
    }

    // Update is called once per frame
    void Update()
    {
        if (changeDirection)
        {
            enemyRB.velocity = new Vector2(1, 0) * -1 * moveSpeed;
            enemyRB.transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
        } else
        {
            enemyRB.velocity = new Vector2(1, 0) * moveSpeed;
            enemyRB.transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //  TODO add something that checks enemy collisions. or makes it so they cannot collide with one another.
        if ((collision.gameObject.tag == "Right") || (collision.gameObject.tag == "Enemy"))
        {
            changeDirection = true;
        } else if (collision.gameObject.tag == "Left")
        {
            changeDirection = false;
        }
        else if (collision.gameObject.tag == "Bottom")
        {
            transform.position = new Vector3(transform.position.x, 6.0f, transform.position.z);
        } else if (collision.gameObject.tag == "Player")
        {
            // send player to lose screen
            audioManager.explosionSFX();
            playerController.resetValues();
            loseWinSceneManager.loadLevel("loseScreen");
        }
    }
}
