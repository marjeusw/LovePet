using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemies;
    public GameObject careroom;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(StartSpawning()); //if we anna make them spawn again

        SpawnStart(); // for the very first start so we don't need to wait 20 seconds
    }

    //IEnumerator StartSpawning()
    //{
    //    yield return new WaitForSeconds(12); //spawn after 4 seconds but we can also make it longer

    //    for (int i = 0; i < 3; i++)
    //    {
    //        Instantiate(enemies[i], spawnPoints[i].position, Quaternion.identity);
    //    }

    //    StartCoroutine(StartSpawning());
    //}

    void SpawnStart() //spawn once and instintly now
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            //GameObject GO = Instantiate(enemies[i], spawnPoints[i].position, Quaternion.identity);

            //enemies[i].transform.parent = careroom;

            enemies[i].SetActive(true);


        }

        Debug.Log("Function called");

        //foreach(Transform child in careroom.transform)
        //{
        //    Debug.Log("Careroom found"+ careroom);
        //    if (child.tag == "CREnemies")
        //    {
        //        child.GetComponent<GameObject>().SetActive(true);

        //    }
        //}
    }
}
