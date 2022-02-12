using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookAt : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    public float lookSpeed = 200;


    void Update()
    {

        Vector3 direction = player.transform.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        Quaternion lookAt = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * lookSpeed);
        transform.rotation = lookAt;


    }


}
