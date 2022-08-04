using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class ImageRecognition : MonoBehaviour
{

    private ARTrackedImageManager _arTrackedImageManager;


    //-----------------------------------//
    private void Awake()
    {
        _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }



    //-----------------------------------//
    public void OnEnable()
    {
        _arTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    public void OnDisable()
    {
        _arTrackedImageManager.trackedImagesChanged -= OnImageChanged;
    }


    //-----------------------------------//
    //---call the unity events here------//
    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);
            //if ___name, do this ___;
        }
    }




}
