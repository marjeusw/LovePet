using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public sealed class MyNetworkManager : MonoBehaviourPunCallbacks
{

    public static MyNetworkManager Instance { set; get; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }



    public void StartConnectServer()
    {
        Debug.Log("Trying to connect to server...");
        PhotonNetwork.ConnectUsingSettings();
    }


    public override void OnConnectedToMaster()
    {
        Debug.Log("...Connected to server");
        PhotonNetwork.JoinLobby();
    }


    public override void OnJoinedLobby()
    {
        Debug.Log("ready to join multiplayer");
    }



    //----------------------------



    //try to find an existing room if there is one
    public void FindMatch()
    {
        Debug.Log("...now finding a room");
        PhotonNetwork.JoinRandomRoom();
    }


    //if joining a random room had failed, then create a new one by yourself;
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        CreateNewRoom();
    }


    private void CreateNewRoom()
    {
        int randomRoomName = Random.Range(0, 9999);
        RoomOptions roomOptions = new RoomOptions()
        {
            IsVisible = true,
            IsOpen = true,
            MaxPlayers = 5,
            PublishUserId = true // other players can see uid
        };

        //create the room with the parameters
        PhotonNetwork.CreateRoom("MyRoomName" + randomRoomName, roomOptions); //create the new room

        //show status in the console
        Debug.Log("MyRoomName" + randomRoomName + "created");

    }

    
    
        public override void OnJoinedRoom()
        {
            Debug.Log("Join room and load scene...");
            PhotonNetwork.LoadLevel(2);
        }



}
