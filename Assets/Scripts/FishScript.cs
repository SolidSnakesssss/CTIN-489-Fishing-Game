using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour
{
    public AudioSource audioSource;
    private ScoreManager _scoreManager;

    void Start()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hook"))
        {
            audioSource.Play();
            
            _scoreManager.IncreaseScore();
            
            Destroy(gameObject);
        }
    }
}
