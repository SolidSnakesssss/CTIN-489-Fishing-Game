using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HumanVoice : MonoBehaviour
{
    public AudioSource audioSource;

    private AudioClip voice1;
    private AudioClip voice2;
    private AudioClip voice3;
    private AudioClip voice4;
    private AudioClip voice5;
    private AudioClip voice6;
    private AudioClip voice7;
    private AudioClip voice8;
    private AudioClip voice9;

    private bool playedThanks = false;

    private int previousVoice;
    // Start is called before the first frame update
    void Start()
    {
        //audioSource.GetComponent<AudioSource>();
        audioSource.volume = 0.317f;

        voice1 = Resources.Load<AudioClip>("My Recordings/Give me an A Pls");
        voice2 = Resources.Load<AudioClip>("My Recordings/Good Feedback");
        voice3 = Resources.Load<AudioClip>("My Recordings/I Love Fishing");
        voice4 = Resources.Load<AudioClip>("My Recordings/Juice");
        voice5 = Resources.Load<AudioClip>("My Recordings/Look at them fishies");
        voice6 = Resources.Load<AudioClip>("My Recordings/No Storm pls");
        voice7 = Resources.Load<AudioClip>("My Recordings/Ocean Juice");
        voice8 = Resources.Load<AudioClip>("My Recordings/Relaxed");
        voice9 = Resources.Load<AudioClip>("My Recordings/Splash (1)");

        StartCoroutine(Voicerover());
    }

    // Update is called once per frame
    private IEnumerator Voicerover()
    {
        WaitForSeconds wait = new WaitForSeconds(10f);

        while (true)
        {
            yield return wait;

            var voiceover = Random.Range(0, 9);
            
            while (true)
            {
                if (voiceover == previousVoice)
                {
                    voiceover = Random.Range(0, 9);
                }
                
                else if (voiceover == 2 && playedThanks)
                {
                    voiceover = Random.Range(0, 9);
                }

                else
                {
                    break;
                }
            }
            
            
            switch (voiceover)
            {
                case 0:
                {
                    audioSource.PlayOneShot(voice1);
                    break;
                }

                case 1:
                {
                    audioSource.PlayOneShot(voice2);
                    playedThanks = true;
                    break;
                }

                case 2:
                {
                    audioSource.PlayOneShot(voice3);
                    break;
                }
                
                case 3:
                {
                    audioSource.PlayOneShot(voice4);
                    break;
                }
                
                case 4:
                {
                    audioSource.PlayOneShot(voice5);
                    break;
                }
                
                case 5:
                {
                    audioSource.PlayOneShot(voice6);
                    break;
                }
                
                case 6:
                {
                    audioSource.PlayOneShot(voice7);
                    break;
                }
                
                case 7:
                {
                    audioSource.PlayOneShot(voice8);
                    break;
                }
                
                case 8:
                {
                    audioSource.PlayOneShot(voice9);
                    break;
                }

                default:
                {
                    audioSource.PlayOneShot(voice4);
                    break;
                }
            }

            previousVoice = voiceover;
        }
    }
}
