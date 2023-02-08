using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textEditor : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI beginLevel;
    public static int Level;
    public static int shipsDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        shipsDestroyed = 0;
        beginLevel.text = ("Level " + (Level).ToString());
        StartCoroutine(takeOffTimer());
    }

    private IEnumerator takeOffTimer()
    {
        yield return new WaitForSeconds(5f);
        beginLevel.gameObject.SetActive(false);
    }
}
