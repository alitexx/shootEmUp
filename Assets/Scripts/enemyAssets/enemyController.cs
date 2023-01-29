using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    private Rigidbody2D enemyRB;
    private bool changeDirection = false;
    public float moveSpeed;

    void Start()
    {
        enemyRB = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (changeDirection)
        {
            enemyRB.velocity = new Vector2(1, 0) * -1 * moveSpeed;
        } else
        {
            enemyRB.velocity = new Vector2(1, 0) * moveSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Right")
        {
            changeDirection = true;
        } else if (collision.gameObject.tag == "Left")
        {
            changeDirection = false;
        }
    }
}
