using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfScript : MonoBehaviour
{
    
    [SerializeField] private GameObject ShelfLayer;
    public GameObject rootObject;

    private VFManager _vfManager;
    private int _shelfHeight;
    public int id;
    void Start()
    {
        _vfManager = rootObject.GetComponent<VFManager>();

        _shelfHeight = _vfManager.shelfHeight;
        
        for (int i = 0; i < _shelfHeight; i++)
        {
            var shelfLayerInstance= Instantiate(ShelfLayer, transform);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
