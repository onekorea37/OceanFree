using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int SCORE;

    public TextMeshProUGUI scoreText;

    public GameObject title, msg1, msg2, msg3, msg4, msg5;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForSec(title));

        msg1.SetActive(false);
        msg2.SetActive(false);
        msg3.SetActive(false);
        msg4.SetActive(false);
        msg5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + SCORE;

        if (SCORE == 10) {
            msg1.SetActive(true);
            StartCoroutine(WaitForSec(msg1));
        }

        if (SCORE == 20) {
            msg2.SetActive(true);
            StartCoroutine(WaitForSec(msg2));
        }

        if (SCORE == 30) {
            msg3.SetActive(true);
            StartCoroutine(WaitForSec(msg3));
        }

        if (SCORE == 50) {
            msg4.SetActive(true);
            StartCoroutine(WaitForSec(msg4));
        }

        if (SCORE == 80) {
            msg5.SetActive(true);
            StartCoroutine(WaitForSec(msg5));
        }
    }

    IEnumerator WaitForSec(GameObject msg) 
    {
        yield return new WaitForSeconds(15);
        Destroy(msg);
    }
}