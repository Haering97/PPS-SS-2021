using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

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

    private GameObject[] shelves;
     
    void Start()
    {
        vfOrigin = transform;
        _spacingShelvesDynamic = (spacingShelves + trayWidth) * globalsize;
        //spacingTraysDynamic = spacingTrays + trayLength;
        shelves = new GameObject[numberOfShelves];
         
        
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
            var shelfScript = shelfInstance.GetComponent<ShelfScript>();
            shelfScript.id = i;

            shelves[i] = shelfInstance;
        }
        
        
        Debug.Log("Farm Instantiated");

        //Testing


    }
    
    void Update()
    {
        
    }

    public float getSpacingTraysDynamic()
    {
        return (spacingTrays + trayLength)*globalsize;
    }

    public Vector3 getTraySize()
    {
        return new Vector3(
            trayWidth + (trayWidth * spacingPlants), 
            1f,
            trayLength + (trayWidth * spacingPlants)
            )*globalsize;
    }

    public Vector3 getOffset()
    {
        return (new Vector3(
            (trayWidth-1) +(trayWidth * spacingPlants), 
            0, 
            (trayLength-1) + (trayLength * spacingPlants))
                * globalsize);
    }
    public Vector3 getRootOffset()
    {
        return (new Vector3(
            (trayWidth * (numberOfShelves-1)) + (spacingShelves * (numberOfShelves-1)), 
            0,
            (trayLength * (shelfLength-1)) + (spacingTrays * (shelfLength-1)))
                * globalsize);
    }
    
    
}

//TODO namen des GameObject zu typ und id ändern damit man alles auch über .find finden kann.