using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class Dialogue
{

    public string NPCname;

    [TextArea(6, 10)]
    public string[] sentences;


}
