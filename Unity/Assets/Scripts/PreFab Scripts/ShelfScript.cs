using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfScript : MonoBehaviour
{
    
    [SerializeField] private GameObject ShelfLayer;
    private VFManager RootObject;

    private VFManager VfManager;
    private int shelfHeight;
    public int id;
    void Start()
    {
        VfManager = RootObject.GetComponent<VFManager>();

        shelfHeight = VfManager.shelfHeight;
        
        for (int i = 0; i < shelfHeight; i++)
        {
            var shelfLayerInstance= Instantiate(ShelfLayer, transform);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
