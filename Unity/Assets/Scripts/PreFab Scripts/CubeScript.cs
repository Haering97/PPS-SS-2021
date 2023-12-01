using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CubeScript : MonoBehaviour
{
    public float moisture;
    public float temp;
    public float growth;

    private Vector3 calculatedGrowth;

    private GameObject cube;

    private VFManager vfManager;

    private float pressTime;
    private bool isPressing = false;
    private Touch touch;
    private GameObject uiimage;
    private bool showUI;
    void Start()
    {
        cube = this.gameObject;
        vfManager = GameObject.Find("Root").GetComponent<VFManager>();
        growth = Random.Range(0.5f, 1.1f);
        calculatedGrowth = cube.transform.localScale * growth;
        uiimage = GameObject.Find("PlantUI");
    }


    void Update()
    {
        //Die Größe des Würfels je nach Modus anzeigen.
        if (vfManager.showGrowth)
        {
            cube.transform.localScale = calculatedGrowth;
        }
        else
        {
            cube.transform.localScale = new Vector3(vfManager.globalsize, vfManager.globalsize, vfManager.globalsize);
        }


        //Long Press auf Würfel öffnet Menü
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            
            //Berührtes Objekt und Zeit messen so lange gedrückt wird.
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Ray ray = GameObject.FindWithTag("MainCamera").GetComponent<Camera>()
                        .ScreenPointToRay(Input.GetTouch(0).position);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
                    {
                        isPressing = true;
                        pressTime = Time.time;
                    }

                    break;
                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    isPressing = false;
                    break;
            }
            
            //Checken ob lange genug gedrückt gehalten wurde.
            if (isPressing && Time.time - pressTime > 1.0f && touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
            {
                Debug.Log("PP-Log: Long Press");
                Debug.Log("PP-Log: " + gameObject.name);
                //Debug.Log("PP-Log: showUI TEST" + showUI);
                uiimage.SetActive(true);
                isPressing = false;
            }
            
            
        }
    }
}