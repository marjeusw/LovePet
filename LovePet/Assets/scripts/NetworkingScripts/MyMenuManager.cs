using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMenuManager : MonoBehaviour
{
    
    public void StartConnectionProcess()
    {
        Debug.Log("Start connection process...");
        MyNetworkManager.Instance.StartConnectServer();

    }

    public void JoinRoom()
    {
        MyNetworkManager.Instance.FindMatch();
    }

}
