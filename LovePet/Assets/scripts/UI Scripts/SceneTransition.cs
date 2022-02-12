using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneTransition
{
    
    public enum Scene
    {
        Home, Tutorial, Credits, Game, OpenSettings
    }


    private Scene selectedScene = Scene.Tutorial;


    private static string SceneName(Scene scene)
    {
        switch (scene)
        {
            case Scene.Home: return "Home";
            case Scene.Tutorial: return "Tutorial";
            case Scene.Credits: return "Credits";
            case Scene.OpenSettings: return "OpenSettings";
        }
        return "";

    }


}
