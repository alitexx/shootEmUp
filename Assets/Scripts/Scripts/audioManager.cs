using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public static AudioSource levelBGM;
    public static AudioSource bulletSFX;
    public static AudioSource takeDamageSFX;


    private void Start()
    {
        levelBGM = this.transform.GetChild(0).GetComponent<AudioSource>();
        bulletSFX = this.transform.GetChild(1).GetComponent<AudioSource>();
        takeDamageSFX = this.transform.GetChild(2).GetComponent<AudioSource>();

        startGame();
    }
    public static void startGame()
    {
        levelBGM.Play();
    }

    public static void playerShoot()
    {
        bulletSFX.Play();
    }
    public static void explosionSFX()
    {
        takeDamageSFX.Play();
    }
}
