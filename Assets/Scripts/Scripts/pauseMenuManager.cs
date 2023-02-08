using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenuManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Canvas pauseMenu;
    [SerializeField] GameObject Enemies;
    [SerializeField] GameObject EnemySpawner;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            togglePause();
        }
    }
    public void togglePause()
    {
        pauseMenu.gameObject.SetActive(!pauseMenu.gameObject.activeInHierarchy);
        EnemySpawner.SetActive(!Enemies.activeInHierarchy);
        Enemies.SetActive(!Enemies.activeInHierarchy);
        player.SetActive(!player.activeInHierarchy);
    }
}
