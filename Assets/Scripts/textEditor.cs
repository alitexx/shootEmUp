using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textEditor : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI beginLevel;
    // Start is called before the first frame update
    void Start()
    {
        if (playerController.levelNum == 0)
        {
            beginLevel.text = ("Level 1");
        } else
        {
            beginLevel.text = ("Level " + (playerController.levelNum).ToString());
        }
        StartCoroutine(takeOffTimer());
    }

    private IEnumerator takeOffTimer()
    {
        yield return new WaitForSeconds(3f);
        beginLevel.gameObject.SetActive(false);
    }
}
