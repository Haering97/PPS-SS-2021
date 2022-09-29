using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfScript : MonoBehaviour
{
    
    [SerializeField] private GameObject ShelfLayer;
    public int id;
    public int shelfHeight;
    public int shelfLength;
    void Start()
    {
        for (int i = 0; i < shelfHeight; i++)
        {
            var shelfLayerInstance= Instantiate(ShelfLayer, transform);
            var shelfLayerScript = shelfLayerInstance.GetComponent<ShelfLayerScript>();
            shelfLayerScript.shelfLength = shelfLength;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
