using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class DummyData : MonoBehaviour
{
    private List<ShelfScript> shelveScripts;

    private List<GameObject> allTrays;
    private List<GameObject> allCubes;

    // Start is called before the first frame update
    void Start()
    {
        shelveScripts = GameObject.Find("Root").GetComponent<VFManager>().shelvesScripts;

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void saveAllTrays()
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
    
    public void fillShelvesRandomColors()
    {
        foreach (var trayObject in allTrays)
        {
            var trayRenderer = trayObject.GetComponent<Renderer>();
            trayRenderer.material.SetColor("_Color",
                UnityEngine.Color.Lerp(Color.green, Color.red, Random.Range(0f, 1f)));
        }
    }
}