using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARFilteredPlanes : MonoBehaviour
{
    [SerializeField] private Vector2 dimensionsForBigPlane; //the big plane must be a multiplication of the two so its recognized (tells how big the big plane must be)


    public event Action OnVerticalPlaneFound;
    public event Action OnHorizontalPlaneFound;
    public event Action OnBigPlaneFound;


    private ARPlaneManager arPlaneManager;
    private List<ARPlane> arPlanes; //store the planes that have been found



    //-----------------------------------//
    //subscribing and unsubscribing to the Plane Found event
    
    public void OnEnable()
    {
        arPlanes = new List<ARPlane>();
        arPlaneManager = FindObjectOfType<ARPlaneManager>();
        arPlaneManager.planesChanged += OnPlanesChanged;
    }

    public void OnDisable()
    {
        arPlaneManager.planesChanged -= OnPlanesChanged;
    }



    //-----------------------------------//
    private void OnPlanesChanged(ARPlanesChangedEventArgs args)
    {

        if(args.added != null && args.added.Count > 0)
        {
            arPlanes.AddRange(args.added);
        }


        //gives minimum filter 0.1sq m
        foreach (ARPlane plane in arPlanes.Where(plane => plane.extents.x * plane.extents.y >= 0.1f))
        {
            
            if (plane.alignment.IsVertical())
            {
                //tell someone we found a vertical plane (Events)
                OnVerticalPlaneFound.Invoke();
            }
            else
            {
                //tell someone we found a horizontal plane (Events)
                OnHorizontalPlaneFound.Invoke();
            }


            if(plane.extents.x * plane.extents.y >= dimensionsForBigPlane.x * dimensionsForBigPlane.y)
            {
                //tell someone we found a big plane (Events)
                OnBigPlaneFound.Invoke();
            }


        }



    }





}
