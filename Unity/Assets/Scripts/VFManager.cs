using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VFManager : MonoBehaviour
{
    [SerializeField] private GameObject shelf;
    [SerializeField] public int numberOfShelves;
    [SerializeField] public int shelfHeight;
    [SerializeField] public int shelfLength;
    [SerializeField] public int trayWidth;
    [SerializeField] public int trayLength;

    static public Transform vfOrigin;

    public float spacingShelves = 2f;
    public float spacingLayer = 2f;
    public float spacingTrays = 2f;
    public float spacingPlants = 0.1f;

    private float _spacingShelvesDynamic;
    private float _spacingTraysDynamic;

    public float globalsize = 1f;

    public List<GameObject> shelves;

    public List<ShelfScript> shelvesScripts;

    [SerializeField] public DummyData dummyData;

    //Denn wir wollen mit dem performanteren Modus starten.
    public bool renderSingleCubes = false;

    private int topLayer;

    //doubletap
    private float lastTap;
    private float lastMiss;

    private int lastShelf;

    //checkButtonHit
    private CheckUi checkUi;

    void Start()
    {
        vfOrigin = transform;
        _spacingShelvesDynamic = (spacingShelves + trayWidth) * globalsize;
        //spacingTraysDynamic = spacingTrays + trayLength;

        GameEvents.current.onUpPress += oneLayerUp;
        GameEvents.current.onDownPress += oneLayerDown;
        GameEvents.current.onSCPress += toggleSC;
        //Murks
        //GameEvents.current.onDataRefresh += highlightShelf;

        topLayer = shelfHeight;

        //checkButtonHit

        checkUi = GameObject.Find("Canvas").GetComponent<CheckUi>();


        //Hier werden so viele Regale instanziiert wie angegeben.
        for (int i = 0; i < numberOfShelves; i++)
        {
            var shelfInstance = Instantiate(shelf, vfOrigin);
            shelfInstance.transform.position += new Vector3(i, 0, 0) * _spacingShelvesDynamic;
            /*
            Debug.Log("RootOffset");
            Debug.Log("X:  "+getRootOffset().x);
            Debug.Log("Z:  "+getRootOffset().z);
            */
            shelfInstance.transform.position -= getRootOffset() / 2;
            shelfInstance.name = "Shelf " + i;
            var shelfScript = shelfInstance.GetComponent<ShelfScript>();
            shelfScript.id = i;
            shelvesScripts.Add(shelfScript);
            shelves.Add(shelfInstance);
        }

        Debug.Log("Farm Instantiated");

        //Testing
        /*
        shelves.ForEach(shelf =>
            shelf.GetComponent<ShelfScript>().shelfLayers.ForEach(layer =>
                layer.GetComponent<ShelfLayerScript>().trays.ForEach(tray =>
                    tray.GetComponent<TrayScript>().cubeObjects.ForEach(cube => cube.SetActive(false)))));
                    */
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            dummyData.fillRandomColors();
        }

        //Wenn mit zwei Fingern gleichzeitig getippt wird, nur zum testen.
        if (Input.touchCount == 2 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            dummyData.fillRandomColors();
        }

        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //TODO effizienter referenzieren.
            Ray ray = GameObject.FindWithTag("MainCamera").GetComponent<Camera>()
                .ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (checkUi.castGR(Input.GetTouch(0).position).Count == 0)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    //Hier checken ob ein Button getroffen wird oder nicht.

                    //Hier checken ob ein GameObject getroffen wird.
                    if (hit.collider != null)
                    {
                        GameObject touchedObject = hit.transform.gameObject;

                        //mithile des Parentings von Transform, kann ich über den würfel auf das regal zugreifen.
                        var hitShelf = touchedObject.transform.parent.parent.parent;

                        string[] subs = hitShelf.name.Split(" ");

                        //Die Nummer des angeklickten Regales zwischenspeichern.
                        var hitShelfNumber = Int32.Parse(subs[subs.Length - 1]);

                        if (Time.time - lastTap <= 0.4f)
                        {
                            //Zweiter Tap unter einer Sekune erkannt.
                            if (hitShelfNumber == lastShelf)
                            {
                                //das selbe regal zweimal hintereinander getapped
                                //TODO das Regal an dem Root punkt schieben und größer scalen mit Animation;
                                highlightShelf(hitShelfNumber);
                                showSingleCubes(true);
                            }
                        }

                        lastTap = Time.time;
                        lastShelf = hitShelfNumber;
                    }
                }
                else
                {
                    //wenn neben die regale getippt wird.
                    if (Time.time - lastMiss <= 0.4f)
                    {
                        //Wenn zweimal neben das shelf getippt wird, sollen wieder alle regale eingeblendet werden.
                        shelves.ForEach(shelf => shelf.SetActive(true));
                        showSingleCubes(false);
                    }

                    lastMiss = Time.time;
                }
            }
        }
    }


    public void setLayerVisibillity(int layer, bool visibility)
    {
        foreach (var shelfScript in shelvesScripts)
        {
            foreach (var shelfLayer in shelfScript.shelfLayersScripts)
            {
                if (shelfLayer.layer == layer)
                {
                    foreach (var tray in shelfLayer.traysScripts)
                    {
                        if (renderSingleCubes)
                        {
                            tray.cubeObjects.ForEach(cube => cube.SetActive(visibility));
                        }
                        else
                        {
                            tray.trayObject.SetActive(visibility);
                        }
                    }
                }
            }
        }
    }

    public void showSingleCubes(bool visibility)
    {
        renderSingleCubes = visibility;
        foreach (var shelfScript in shelvesScripts)
        {
            foreach (var shelflayer in shelfScript.shelfLayersScripts)
            {
                foreach (var tray in shelflayer.traysScripts)
                {
                    tray.cubeObjects.ForEach(cube => cube.SetActive(visibility));
                    tray.trayObject.SetActive(!visibility);
                }
            }
        }

        setTopLayer();
    }

    /* OLD WAY WITHOUT SCRIPT REFERENCE
    public void showSingleCubes(bool visibillity)
    {
        foreach (var shelf in shelves)
        {
            foreach (var layer in shelf.GetComponent<ShelfScript>().shelfLayers)
            {
                foreach (var tray in layer.GetComponent<ShelfLayerScript>().trays)
                {
                    var trayScript = tray.GetComponent<TrayScript>();
                    trayScript.cubeObjects.ForEach(cube => cube.SetActive(visibillity));
                    trayScript.trayObject.SetActive(!visibillity);
                }
            }
        }
    }*/


    public float getSpacingTraysDynamic()
    {
        return (spacingTrays + trayLength) * globalsize;
    }

    public Vector3 getTraySize()
    {
        return new Vector3(
            trayWidth + (trayWidth * spacingPlants),
            1f,
            trayLength + (trayWidth * spacingPlants)
        ) * globalsize;
    }

    public Vector3 getOffset()
    {
        return (new Vector3(
                    (trayWidth - 1) + (trayWidth * spacingPlants),
                    0,
                    (trayLength - 1) + (trayLength * spacingPlants))
                * globalsize);
    }

    public Vector3 getRootOffset()
    {
        return (new Vector3(
                    (trayWidth * (numberOfShelves - 1)) + (spacingShelves * (numberOfShelves - 1)),
                    0,
                    (trayLength * (shelfLength - 1)) + (spacingTrays * (shelfLength - 1)))
                * globalsize);
    }

    private void zoomBigger()
    {
        this.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f) * (this.transform.localScale.magnitude * 0.2f);
    }

    private void zoomSmaller()
    {
        this.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f) * (this.transform.localScale.magnitude * 0.2f);
    }

    private void oneLayerUp()
    {
        topLayer++;
        if (topLayer > shelfHeight)
        {
            topLayer = shelfHeight;
        }

        setTopLayer();
    }

    private void oneLayerDown()
    {
        topLayer--;
        if (topLayer < 1)
        {
            topLayer = 1;
        }

        setTopLayer();
    }

    private void setTopLayer()
    {
        for (int i = 0; i < topLayer; i++)
        {
            setLayerVisibillity(i, true);
        }

        for (int j = topLayer; j < shelfHeight; j++)
        {
            setLayerVisibillity(j, false);
        }
    }

    private void toggleSC()
    {
        renderSingleCubes = !renderSingleCubes;
        showSingleCubes(renderSingleCubes);
    }

    private void highlightShelf(int shelfNumber)
    {
        foreach (var shelf in shelves)
        {
            if (shelf.GetComponent<ShelfScript>().id != shelfNumber)
            {
                shelf.SetActive(false);
            }
        }
    }
}

//TODO namen des GameObject zu typ und id ändern damit man alles auch über .find finden kann.