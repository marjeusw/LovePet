using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning()); //if we anna make them spawn again

        SpawnStart(); // for the very first start so we don't need to wait 20 seconds
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(12); //spawn after 4 seconds but we can also make it longer

        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemies[i], spawnPoints[i].position, Quaternion.identity);
        }

        StartCoroutine(StartSpawning());
    }

    void SpawnStart() //spawn once and instintly now
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemies[i], spawnPoints[i].position, Quaternion.identity);
        }
    }
}
