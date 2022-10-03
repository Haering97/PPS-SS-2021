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
    
    public float spacingShelves = 5f;
    public float spacingLayer = 2f;
    public float spacingPlants = 0.1f;
    
    public float globalsize = 1f;

    void Start()
    {
        vfOrigin = transform;
        for (int i = 0; i < numberOfShelves; i++)
        {
            var shelfInstance = Instantiate(shelf, vfOrigin);
            shelfInstance.transform.position += new Vector3(i, 0, 0) * spacingShelves;
            var shelfScript = shelfInstance.GetComponent<ShelfScript>();
            shelfScript.id = i;
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
