using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject enemy1;
    public GameObject enemy2;

    private bool enemyToSpawn; // true is enemy1, false is enemy2

    private bool debounce = false;
    void Start()
    {
        
    }

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
        yield return new WaitForSeconds(5f);
        // spawn enemy
        if (enemyToSpawn) {
            Instantiate(enemy1, spawnPoint.position, Quaternion.identity);
        } else
        {
            Instantiate(enemy2, spawnPoint.position, Quaternion.identity);
        }
        debounce = false;
    }


}
