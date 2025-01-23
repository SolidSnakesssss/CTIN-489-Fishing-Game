using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseScore : MonoBehaviour
{
    private ScoreManager _scoreManager;

    public AudioSource splashSFX;
    // Start is called before the first frame update
    void Start()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("RightFish"))
        {
            //Debug.Log("HIIII");
            _scoreManager.IncreaseScore();
            splashSFX.Play();
        }
        
        
        else if (collision.gameObject.name.StartsWith(("LeftFish")))
        {
            _scoreManager.IncreaseScore();
            splashSFX.Play();
        }
        
    }
}
