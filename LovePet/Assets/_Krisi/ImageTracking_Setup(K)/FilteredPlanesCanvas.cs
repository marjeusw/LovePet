using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilteredPlanesCanvas : MonoBehaviour
{

    [SerializeField] private Toggle verticalPlaneToggle;
    [SerializeField] private Toggle horizontalPlaneToggle;
    [SerializeField] private Toggle bigPlaneToggle;

    [SerializeField] private Button startButton; //change this to the scenechange button?

    
    private ARFilteredPlanes arFilteredPlanes;


    //-----------------------------------//
    public bool VerticalPlaneToggle
    {
        get => verticalPlaneToggle.isOn;
        set
        {
            verticalPlaneToggle.isOn = value;
            CheckIfAllAreTrue();
        }
    }

    public bool HorizontalPlaneToggle
    {
        get => horizontalPlaneToggle.isOn;
        set
        {
            horizontalPlaneToggle.isOn = value;
            CheckIfAllAreTrue();
        }
    }

    public bool BigPlaneToggle
    {
        get => bigPlaneToggle.isOn;
        set
        {
            bigPlaneToggle.isOn = value;
            CheckIfAllAreTrue();
        }
    }


    //-----------------------------------//
    public void OnEnable()
    {
        arFilteredPlanes = FindObjectOfType<ARFilteredPlanes>();

        arFilteredPlanes.OnVerticalPlaneFound += () => verticalPlaneToggle.isOn = true; // ??
        arFilteredPlanes.OnHorizontalPlaneFound += () => horizontalPlaneToggle.isOn = true;
        arFilteredPlanes.OnBigPlaneFound += () => bigPlaneToggle.isOn = true;
    }

    public void OnDisable()
    {
        arFilteredPlanes.OnVerticalPlaneFound -= () => verticalPlaneToggle.isOn = true; // ??
        arFilteredPlanes.OnHorizontalPlaneFound -= () => horizontalPlaneToggle.isOn = true;
        arFilteredPlanes.OnBigPlaneFound -= () => bigPlaneToggle.isOn = true;
    }


    //-----------------------------------//
    private void CheckIfAllAreTrue()
    {
        if (VerticalPlaneToggle && HorizontalPlaneToggle & BigPlaneToggle)
        {
            startButton.interactable = true;
        }

    }



}
