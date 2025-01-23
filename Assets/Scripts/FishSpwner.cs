using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FishSpwner : MonoBehaviour
{
    public float speed;

    public float direction;

    //private float Spawnrate = 1f;

    [SerializeField] private GameObject[] fishPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(1f);

        while (true)
        {
            yield return wait;

            float randY = Random.Range(110f, 270f);

            int randSpawn = Random.Range(0, fishPrefab.Length);
            Vector3 currentPos = new Vector3(transform.position.x, randY, transform.position.z);
            
            Instantiate(fishPrefab[randSpawn], currentPos, Quaternion.identity);
            
            
        }
    }
}
