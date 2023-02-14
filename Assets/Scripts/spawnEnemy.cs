using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject enemy1;
    public GameObject enemy2;
    public Transform enemyParent;

    private int enemyTimer = 0;
    private bool openedPause = false;

    private bool enemyToSpawn = false; // true is enemy1, false is enemy2

    private bool debounce = false;

    // Update is called once per frame
    void Update()
    {
        if (debounce == false)
        {
            debounce = true;
            StartCoroutine(enemySpawner());
        }
    }

    private IEnumerator enemySpawner()
    {

        // spawn enemy
        for (int i = 0; i <= 8; i++)
        {
            if (!pauseMenuManager.isActive)
            {
                if (openedPause)
                {
                    openedPause = false;
                    i = enemyTimer;
                } else
                {
                    enemyTimer = i;
                }
                yield return new WaitForSeconds(0.5f);
                if (pauseMenuManager.isActive)
                {
                    // this bool is used to see if the pause menu has recently been opened
                    openedPause = true;
                    break;
                }
            }
        }
        // reset the timer
        enemyTimer = 0;
        //checks if pause is open. if so then just skip all of this tbh
        if (!pauseMenuManager.isActive)
        {
            if (enemyToSpawn)
            {
                Instantiate(enemy1, spawnPoint.position, Quaternion.identity, enemyParent);
            }
            else
            {
                Instantiate(enemy2, spawnPoint.position, Quaternion.identity, enemyParent);
            }
            enemyToSpawn = !enemyToSpawn;
        }
        debounce = false;
    }


}
