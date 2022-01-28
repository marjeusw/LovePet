using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public Image healthBar;
    public float healthAmount = 100;
    public float damageDealth = 20;
    public float healPoints = 10;


    private void Update()
    {
        if(healthAmount <= 0)
        {
            //Application.LoadLevel(Application.LoadLevel);
            Debug.Log("player 0 health");

        }


        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(damageDealth);
        }



        if (Input.GetKeyDown(KeyCode.T))
        {
            Healing(healPoints);
        }



    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100;
    }


    public void Healing(float healPoints)
    {
        healthAmount += healPoints;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100); //make sure it doesnt go past the maximum

        healthBar.fillAmount = healthAmount / 100;
    }



}
