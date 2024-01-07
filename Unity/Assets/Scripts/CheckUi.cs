using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CheckUi : MonoBehaviour
{
    private GameObject buttonSG;
    private VFManager vfManager;
    void Start()
    {
        buttonSG = GameObject.Find("ButtonSG");
        vfManager = GameObject.Find("Root").GetComponent<VFManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Hier Blende ich den Button nur ein wenn einzelne Cubes zu sehen sind.
        if (!vfManager.renderSingleCubes) 
        {
            buttonSG.SetActive(false);
        }
        else
        {
            buttonSG.SetActive(true);
        }
    }

    public System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> castGR(Vector2 pos)
    {
        GraphicRaycaster gr = this.GetComponent<GraphicRaycaster>();
        //Create the PointerEventData with null for the EventSystem
        PointerEventData ped = new PointerEventData(null);
        //Set required parameters, in this case, mouse position
        ped.position = pos;
        //Create list to receive all results
        List<RaycastResult> results = new List<RaycastResult>();
        //Raycast it
        gr.Raycast(ped, results);
            
        return results;
    }
    
}
