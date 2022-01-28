using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//gotta fix
public class Countdown : MonoBehaviour
{

    public float timeStart = 5;   //from where should the countdown start?

    public Text textRunningCooldown;  //this holds the TextBox gameobject
    public Text textWaitForCooldown;

    bool timerActive = false;


    

    void Start()
    {
        textRunningCooldown.text = timeStart.ToString();
    }




    void Update()
    {

        if(timerActive == true)
        {
            timeStart -= Time.deltaTime;  //time.deltatime keeps the countdown consistent
            textRunningCooldown.text = Mathf.Round(timeStart).ToString(); //rounding the output so we clean up the time value
        }
        
    }




    public void StartCountdown()
    {
        timerActive = !timerActive; //
        textWaitForCooldown.text = timerActive ? "Wait" : "Use";
    }



}
