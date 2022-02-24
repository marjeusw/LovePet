using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticField : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject gloob;

    [SerializeField]
    private GameObject gloobProjectile;

    private float dist = 2f;
    public float gloobSpeed = 2f;  //set this to a minus number to apply the anti magnet and push things away from a distance
    public float howClose = 2f;  //how close do we have to be to the Gloob until it starts to attack us


    
    void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);  //(player pos, enemy pos)

        if(dist <= howClose)
        {
            transform.LookAt(player.transform.position);
            GetComponent<Rigidbody>().AddForce(transform.forward * gloobSpeed);
        }

        if(dist <= 1.5)
        {
            //do 40f damage to the player;

            //VFX:
            //explode into the phone
            //make the screen glitch so everything´s unseeable

            //remove VFX after 5 seconds & destroy the enemy and the pet
        }

    }



    /*
    public void GloobShoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(gloob.transform.position, gloob.transform.forward, out hit))
        {
            if(hit.transform.name == "arCamera")
            {
                Destroy(hit.transform.gameObject);

                Instantiate(gloobProjectile, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }
    }
    */


}
