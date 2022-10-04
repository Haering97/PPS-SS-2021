using System.Collections;
using System.Collections.Generic;
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

    
    
    void Start()
    {
        vfOrigin = transform;
        _spacingShelvesDynamic = spacingShelves + trayWidth;
        //spacingTraysDynamic = spacingTrays + trayLength;
        
         

        
        
        for (int i = 0; i < numberOfShelves; i++)
        {
            var shelfInstance = Instantiate(shelf, vfOrigin);
            shelfInstance.transform.position += new Vector3(i, 0, 0) * _spacingShelvesDynamic;
            var shelfScript = shelfInstance.GetComponent<ShelfScript>();
            shelfScript.id = i;
        }
        

    }
    
    void Update()
    {
        
    }

    public float getSpacingTraysDynamic()
    {
        return spacingTrays + trayLength;
    }

    public Vector3 getTraySize()
    {
        return new Vector3(trayWidth + (trayWidth * spacingPlants), 1f, trayLength + (trayWidth * spacingPlants));
    }

    public Vector3 getOffset()
    {
        return (new Vector3((trayWidth-1) +(trayWidth * spacingPlants), 0, (trayLength-1) + (trayLength * spacingPlants)) * globalsize);
    }
}
