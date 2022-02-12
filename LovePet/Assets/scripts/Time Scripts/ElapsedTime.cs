using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ElapsedTime : MonoBehaviour
{
    [SerializeField]
    private TMP_Text textTimer;

    private float timer = 0.0f;
    private bool isTimer = true;


    void Update()
    {
        if (isTimer)
        {
            timer += Time.deltaTime;
            DisplayTime();
        }

    }


    void DisplayTime()
    {
        int minutes = Mathf.FloorToInt(timer / 60.0f);
        int seconds = Mathf.FloorToInt(timer - minutes *60.0f);

        textTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }



    public void HoldTimer()
    {

        if (isTimer == false)
        {
            isTimer = true;
        }
        else
        {
            isTimer = false;
        }

    }


    /*
    public void ResetTimer()
    {
        timer = 0.0f;
    }
    */

}
