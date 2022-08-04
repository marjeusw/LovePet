using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomManager : MonoBehaviour
{
    public static RoomManager Instance { set; get; }
    [SerializeField] private GameObject WholePlayer;
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    private void OnEnable()
    {
        //register to delegate
        SceneManager.sceneLoaded += OnSceneLoad;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoad;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoad;
    }

    private void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        Vector3 spawningPos = new Vector3(Random.Range(-3f, 3f), 2.0f, Random.Range(-3f, 3f)); 
        Vector3 playerSpawningPos = new Vector3(Random.Range(-3f, 3f), 2.0f, Random.Range(-3f, 3f));


        if (PhotonNetwork.InRoom)
        {
            //Instanciates by name (careful with spelling)
            PhotonNetwork.Instantiate("WholePlayer", playerSpawningPos, Quaternion.identity); //maybe only 1 for now to see if it works
            PhotonNetwork.Instantiate("blob", spawningPos, Quaternion.identity);
        }
        else
        {
            Instantiate(Resources.Load("WholePlayer"), playerSpawningPos, Quaternion.identity);
            Instantiate(Resources.Load("blob"), spawningPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
