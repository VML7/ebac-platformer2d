using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColectCoin : MonoBehaviour
{
    public TMP_Text scoreTxt;
    private int score;

    void Start()
    {
        score = 0;
    }


    void Update()
    {
        scoreTxt.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin")== true)
        {
            score = score + 1;
            Destroy(collision.gameObject);
        }
    }
}
