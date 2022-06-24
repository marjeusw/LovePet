using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomizationText : MonoBehaviour
{

    [SerializeField] TMP_Text _text;
    [SerializeField] Customizable _customizable;


    void OnValidate()
    {
        _text = GetComponent<TMP_Text>();
        _customizable = FindObjectOfType<Customizable>();
    }


    
    void Update()
    {
        //_text.SetText(_customizable.CurrentCustomization?.DisplayName);
    }


}
