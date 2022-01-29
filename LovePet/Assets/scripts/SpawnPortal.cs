using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPortal : MonoBehaviour
{
    public GameObject portal;
    //private Cursor cursor;
    public GameObject cursorr;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

        GameObject obj = Instantiate(portal, cursorr.transform.position, cursorr.transform.rotation);
        cursorr.SetActive(false);
        
        }
}
