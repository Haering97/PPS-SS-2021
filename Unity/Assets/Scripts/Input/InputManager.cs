using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private TouchControls controls;
    private Coroutine zoomCoroutine;
    
    private void Awake()
    {
        controls = new TouchControls();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Start()
    {
        controls.Touch.SecondaryTouchContact.started += _ => ZoomStart();
        controls.Touch.SecondaryTouchContact.canceled += _ => ZoomEnd();
    }

    private void ZoomStart()
    {
        zoomCoroutine = StartCoroutine(Zoomdetection());
    }
    private void ZoomEnd()
    {
        StopCoroutine(zoomCoroutine);
    }

    IEnumerator Zoomdetection()
    {
        var distance = 0f;
        var prevDist = 0f;
        while (true)
        {
            distance = Vector2.Distance(controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>(),
                controls.Touch.SecondaryFingerPosition.ReadValue<Vector2>());
            //Detection
            //Zoom Out
            if (distance > prevDist)
            {
                //Wieso this?
                this.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f) * (this.transform.localScale.magnitude * 0.2f);
            }
            //Zoom In
            else if (distance < prevDist)
            {
                this.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f) * (this.transform.localScale.magnitude * 0.2f);
                
            }

            prevDist = distance;
            yield return null;
        }

    }
}
