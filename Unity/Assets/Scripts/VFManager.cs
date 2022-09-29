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

    void Start()
    {
        vfOrigin = transform;
        for (int i = 0; i < numberOfShelves; i++)
        {
            var shelfInstance = Instantiate(shelf, vfOrigin);
            var shelfScript = shelf.GetComponent<ShelfScript>();
            shelfScript.id = i;
            shelfScript.shelfHeight = shelfHeight;
            shelfScript.shelfLength = shelfLength;
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
