using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageManager : MonoBehaviour
{
   
    //has the user already gone through the tutorial once?
    public static bool didShowTutorial
    {
        get
        {
            return PlayerPrefs.GetInt("didShowTutorial", 0) == 1; //if the "" value doesnt exist yet, give me a 0;
        }
    }


    //to get the value from another script ->  StorageManager.SetTutorialAsShown();
    public static void SetTutorialAsShown()
    {
            PlayerPrefs.SetInt("didShowTutorial", 1);
    }


    //can repeat Tutorial with the click of a button


    public class PlayerPrefsKey
    {
        public static string didShowTutorial = "didShowTutorial";

    }

}
