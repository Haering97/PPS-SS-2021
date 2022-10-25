using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class DummyData : MonoBehaviour
{
    private List<ShelfScript> shelveScripts;

    /* Vorerst nicht implementiert
    private List<GameObject> allTrays;
    private List<GameObject> allCubes;
    
    private bool wasExecuted = false;
    */
    
    void Start()
    {
        shelveScripts = GameObject.Find("Root").GetComponent<VFManager>().shelvesScripts;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* vorerst nicht implementiert
    public void saveAllGOs()
    {
        //Alle GameObjekte in Listen speichern, für einfacheren Zugriff, momentan jedoch kein wirklich gezielter Zugriff bis auf Index möglich.
        foreach (var shelfScript in shelveScripts)
        {
            foreach (var layerScript in shelfScript.shelfLayersScripts)
            {
                foreach (var trayScript in layerScript.traysScripts)
                {
                    allTrays.Add(trayScript.trayObject);

                    foreach (var cube in trayScript.cubeObjects)
                    {
                        allCubes.Add(cube);
                    }
                }
            }
        }
    }
    */
    
    public void fillRandomColors()
    {
        
        foreach (var shelfScript in shelveScripts)
        {
            foreach (var layerScript in shelfScript.shelfLayersScripts)
            {
                foreach (var trayScript in layerScript.traysScripts)
                {
                    trayScript.trayObject.GetComponent<Renderer>().material.SetColor("_Color",
                        UnityEngine.Color.Lerp(Color.green, Color.red, Random.Range(0f, 1f)));

                    foreach (var cube in trayScript.cubeObjects)
                    {
                        cube.GetComponent<Renderer>().material.SetColor("_Color",
                            UnityEngine.Color.Lerp(Color.green, Color.red, Random.Range(0f, 1f)));

                    }
                }
            }
        }
        
    }
}