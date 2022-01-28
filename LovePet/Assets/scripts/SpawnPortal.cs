using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPortal : MonoBehaviour
{
    public GameObject Portal;
    private Cursor cursor;
    public GameObject Cursorr;
   

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
        //GameObject obj = Instantiate(Portal, cursor.transform.position, cursor.transform.rotation);
    }
}
