using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Cooldown : MonoBehaviour
{

    //private remains private, but its still accessible from the editor
    [SerializeField] 
    private Image imgCooldownOverlay;
    [SerializeField]
    private TMP_Text textCooldown;


    private bool isCooldown = false;
    private float cooldownTime = 5.0f; //how much time it lasts
    private float cooldownTimer = 0.0f; //




    void Start()
    {

        textCooldown.gameObject.SetActive(false); //hide the overlay image for the cooldown when the button is ready to use
        imgCooldownOverlay.fillAmount = 0.0f;

    }




    void Update()
    {
        if (isCooldown)
        {
            ApplyCooldown();
        }

    }




    void ApplyCooldown() //applying the cooldown
    {
        cooldownTimer -= Time.deltaTime; //count down from the given starting point


        if (cooldownTimer < 0.0f)  //if cooldown has ended
        {
            isCooldown = false;
            textCooldown.gameObject.SetActive(false);
            imgCooldownOverlay.fillAmount = 0.0f;
        }
        else   //if cooldown is still active. update how much overlayfill is left
        {
            textCooldown.text = Mathf.RoundToInt(cooldownTimer).ToString();
            imgCooldownOverlay.fillAmount = cooldownTimer / cooldownTime;
        }



    }



    public void ThrowNet() //what to do when the Net is ready to use
    {

        if (isCooldown)
        {
            //user has clicked button while in use

                //could add a sound that the user can´t use the button yet
        }
        else
        {
            isCooldown = true;
            textCooldown.gameObject.SetActive(true);
            cooldownTimer = cooldownTime;

        }



    }





}
