using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text counterText;

    [SerializeField] int scoreCount;

    [SerializeField] GameObject winText;

    [SerializeField] GameObject shootSound;


    public void RaiseScore()
    {
        scoreCount++;
        counterText.text = scoreCount.ToString();
        shootSound.GetComponent<AudioSource>().Play();

        if (scoreCount == 10)
        {
            winText.SetActive(true);
           
           
        }

    }
}