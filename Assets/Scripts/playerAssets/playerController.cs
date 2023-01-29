using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    private float moveSpeed = 10.0f;
    private Rigidbody2D rigidBod;

    // Start is called before the first frame update
    void Start()
    {
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
