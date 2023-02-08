using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class playerController : MonoBehaviour
{
    // if the players only gonna have 1 life then. just do a bool
    public static bool isDead;
    public static int playerPoints = 0;
    public static int levelNum;
    public static GameObject pointGUI;

    private float moveSpeed = 10.0f;
    private Rigidbody2D rigidBod;

    // Start is called before the first frame update
    void Start()
    {
        // the default for null in integers is 0 so this should work
        if (levelNum == 0)
        {
            levelNum = 1;
        }
        isDead = false;
        rigidBod = GetComponent<Rigidbody2D>();
        // todo make this a tmp
        pointGUI = GameObject.Find("/PointsGUI/Points");
}
    private void FixedUpdate()
    {
        playerMovement();
    }

    public void playerMovement()
    {
        rigidBod.velocity = new Vector2(Input.GetAxis("Horizontal"), rigidBod.velocity.y) * moveSpeed;
    }

    public static void increasePlayerPoints()
    {
        playerPoints++;
        // TODO update at home
        pointGUI.GetComponent<TextMeshProUGUI>().text = "Points:::";
       if (playerPoints >= 5)
        {
            playerPoints = 0;
            levelNum++;
            if (levelNum >= 3)
            {
                resetValues();
                SceneManager.LoadScene("winScreen");
            }
            else
            {
                SceneManager.LoadScene("Game");
            }
        }
       
    }
    public static void resetValues()
    {
        playerPoints = 0;
        levelNum = 0;
    }
}
