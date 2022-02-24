using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//not working now

public class EnemyAttack : MonoBehaviour
{

    public GameObject arCamera;  // player

    public float damage = 20;

    public GameObject takenDMGfx; // the dmg corner effect when user takes dmg. should be in the PlayerStats script

    public GameObject gooProjectile;
    public float attackCooldown;
    bool alreadyAttacked;


    public float attackRange;
    bool inAttackRange;



    private void Update()
    {


        //if (arCamera collides with enemy collider area) AttackPlayer();


    }


    public void AttackPlayer()
    {

        //GameObject.transform.LookAt(arCamera);


        //instantiate projectile
        Rigidbody rb = Instantiate(gooProjectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
        rb.AddForce(transform.up * 8f, ForceMode.Impulse);
        //



        //if enemy autoaim attack hits the aR camera
        //  instantiate takendmgfx  
        //  playerHealth -= damage;

    }





}
