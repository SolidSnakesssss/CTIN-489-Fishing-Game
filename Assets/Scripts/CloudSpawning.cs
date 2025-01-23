using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawning : MonoBehaviour
{
    [SerializeField] private float spawnRate = 0.5f;

    [SerializeField] private GameObject[] clouds;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (true)
        {
            yield return wait;

            int rand = Random.Range(0, clouds.Length);
            int randPos = Random.Range(480, 595);

            //GameObject cloud = clouds[rand];

            Vector3 cloudPos = new Vector3(transform.position.x, randPos, transform.position.z);

            Instantiate(clouds[rand], cloudPos, Quaternion.identity);
        }
    }
}
