using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PetFollow : MonoBehaviour
{
    public GameObject RescuedPet;
    public GameObject player;

    private bool isRescued = false;



    private void Update()
    {
        RescueConditions();
        StartFollowing();
    }



    void RescueConditions()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            isRescued = true;
        }

    }



    void StartFollowing()
    {

        if (isRescued == true)
        {
            RescuedPet.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
        }
        else
        {
            return;
        }

    }

}
