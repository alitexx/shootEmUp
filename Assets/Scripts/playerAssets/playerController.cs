using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // if the players only gonna have 1 life then. just do a bool
    public static bool isDead;

    private float moveSpeed = 10.0f;
    private Rigidbody2D rigidBod;

    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        rigidBod = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        playerMovement();
    }

    public void playerMovement()
    {
        rigidBod.velocity = new Vector2(Input.GetAxis("Horizontal"), rigidBod.velocity.y) * moveSpeed;
    }
}
