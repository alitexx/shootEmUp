using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject enemy1;
    public GameObject enemy2;
    public Transform enemyParent;

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
        yield return new WaitForSeconds(4f);
        if (enemyToSpawn) {
            Instantiate(enemy1, spawnPoint.position, Quaternion.identity, enemyParent);
        } else
        {
            Instantiate(enemy2, spawnPoint.position, Quaternion.identity, enemyParent);
        }
        enemyToSpawn = !enemyToSpawn;
        debounce = false;
    }


}
