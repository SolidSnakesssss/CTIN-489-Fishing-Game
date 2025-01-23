using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MoveFishLeft : MonoBehaviour
{
    public AudioSource audioSource;
    public Rigidbody2D rb;
    
    
    //private float speed;

    // Start is called before the first frame update
    void Start()
    {
        float speed = Random.Range(150f, 200f);

        if (rb != null)
        {
            rb.velocity = new Vector2(-speed, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hook"))
        {
            //Debug.Log("Hit the Hook!");
            //audioSource.Play();
            
            //_scoreManager.IncreaseScore();
            
            Destroy(gameObject);
        }
        
        else if (collision.gameObject.name.StartsWith("Boundary2"))
        {
            Destroy(gameObject);
        }
    }
}
