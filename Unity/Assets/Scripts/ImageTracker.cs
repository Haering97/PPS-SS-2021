using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageTracker : MonoBehaviour
{
    [SerializeField] [Tooltip("Image manager on the AR Session Origin")]
    ARTrackedImageManager m_TrackedImageManager;

    [SerializeField] [Tooltip("Reference Image Library")]
    XRReferenceImageLibrary m_ImageLibrary;

    [SerializeField] private GameObject model;

    private GameObject instance;

    void OnEnable() => m_TrackedImageManager.trackedImagesChanged += OnChanged;

    void OnDisable() => m_TrackedImageManager.trackedImagesChanged -= OnChanged;

    void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var trackedImage in eventArgs.added)
        {
            var imageName = trackedImage.referenceImage.name;
            Debug.Log("PP-Log: Image Tracked");
            Debug.Log("PP-Log:" + trackedImage.referenceImage.name);

            var offsetPos = new Vector3(0f, 0.1f, 0);
            //var scaleFactor = 0.5f;
            //TODO Rotation auslagern und im UI bereitstellen
            //TODO Multiple Prefabs and referenceImages
            //TODO Dynamic Prefabs

            instance = Instantiate(model, trackedImage.transform.position, trackedImage.transform.rotation);
            instance.name = "Root";


            /* OLD WAY 
            var newPrefab = Instantiate(model,
                trackedImage.transform.position + offsetPos,
                trackedImage.transform.rotation *
                Quaternion.Euler(20,
                    0,
                    0),
                trackedImage.transform);
            */


            /*
            for(int i = 0; i < m_ImageLibrary.count ; i++)
            {
                Debug.Log("PP-Log:" +m_ImageLibrary[i].name);
            }
            */
        }

        foreach (var updatedImage in eventArgs.updated)
        {
            //Debug.Log(updatedImage.trackableId);
            instance.transform.position = updatedImage.transform.position;
            instance.transform.rotation = updatedImage.transform.rotation;
            // Handle updated event
        }

        foreach (var removedImage in eventArgs.removed)
        {
            // Handle removed event
        }
    }
}