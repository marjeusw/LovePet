using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{

    [SerializeField]
    private GameObject NewPanel;

    [SerializeField]
    private GameObject OldPanel;


    public void OpenNewPanel()
    {


        if(NewPanel != null)
        {
            NewPanel.SetActive(true);

            if (OldPanel != null)
            {
                OldPanel.SetActive(false);
            }

        }


    }




}
