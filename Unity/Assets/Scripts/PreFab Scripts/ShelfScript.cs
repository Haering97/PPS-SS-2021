using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfScript : MonoBehaviour
{
    
    [SerializeField] private GameObject ShelfLayer;
    //[SerializeField] private GameObject VFManager;
    public VFManager VfManager;
    
    private int shelfHeight;
    public int id;
    void Start()
    {
        VfManager = GameObject.Find("Root").GetComponent<VFManager>();

        shelfHeight = VfManager.shelfHeight;
        
        for (int i = 0; i < shelfHeight; i++)
        {
            var shelfLayerInstance= Instantiate(ShelfLayer, transform);
            var shelfLayerScript = shelfLayerInstance.GetComponent<ShelfLayerScript>();
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
