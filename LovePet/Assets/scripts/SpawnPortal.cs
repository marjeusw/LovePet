using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPortal : MonoBehaviour
{
    public GameObject portal;
    //private Cursor cursor;
    public GameObject cursorr;
    public GameObject cursorrSecWorld;
    private bool portalSpawned = false;
    private GameObject portalStorage;
   

   

    // Start is called before the first frame update
    void Start()
    {
        portalStorage = Instantiate(portal, new Vector3(0,0,0), Quaternion.identity);
        portalStorage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (portalSpawned)
        //{

        //    PressedButton();
        //}

        //if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        //{
            
        //        GameObject obj = Instantiate(Portal,cursor.transform.position, cursor.transform.rotation);
        //        Cursorr.SetActive(false);

                
        //}
    }

    public void PressedButton()
    {
        //print($"PortalIs {portal}");
        //print($"CursorIs {cursorr.transform.position}");
        //print($"CursorIs {cursorr.transform.rotation}");

        //GameObject obj = Instantiate(portal, cursorr.transform.position, cursorr.transform.rotation);
        //cursorr.SetActive(false);
        //portalSpawned = true;


        if (portalSpawned == false)
        {
            portalStorage.transform.position = cursorr.transform.position;
            portalStorage.transform.rotation = cursorr.transform.rotation;
            portalStorage.SetActive(true);

            cursorr.SetActive(false);
            cursorrSecWorld.SetActive(false);
            portalSpawned = true;
            
        }
        else
        {
            if (portalStorage != null) //no null reference
            {
                cursorr.SetActive(true);
                cursorrSecWorld.SetActive(true);
                //Destroy(portalStorage);
                portalStorage.SetActive(false);
                portalSpawned = false;
                
            }
        }

    }

    //public void ButtonPressedAgain()
    //{
    //    if (portalSpawned == false)
    //    {
    //        portalSpawned = true;
    //    }
    //    else
    //    {
    //        portalSpawned = false;
    //    }
    //}
}
