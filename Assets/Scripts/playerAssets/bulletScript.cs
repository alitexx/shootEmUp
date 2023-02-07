using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class bulletScript : MonoBehaviour
{
    private Rigidbody2D bulletRB;
    private float moveSpeed = 10.0f;
    [SerializeField] TextMeshProUGUI points;



    void Start()
    {
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
            collision.gameObject.SetActive(false);
            textEditor.shipsDestroyed += 1;
            points.text = ("Points: " + ((int)(textEditor.shipsDestroyed)).ToString());
            if (textEditor.shipsDestroyed >= 3)
            {
                textEditor.Level += 1;
                if (textEditor.Level >= 3)
                {
                    SceneManager.LoadScene("WIN");
                    return;
                }
                SceneManager.LoadScene("Game");
            }
        }
        else if (collision.gameObject.tag == "Top")
        {
            Destroy(gameObject);
        }
    }
}
