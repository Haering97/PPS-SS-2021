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
    public List<GameObject> shelfLayers;

    void Start()
    {
        _vfManager = rootObject.GetComponent<VFManager>();

        _shelfHeight = _vfManager.shelfHeight;

        for (int i = 0; i < _shelfHeight; i++)
        {
            var shelfLayerInstance = Instantiate(ShelfLayer, transform);
            shelfLayerInstance.transform.position +=
                new Vector3(0, i, 0) * _vfManager.spacingLayer * _vfManager.globalsize;
            shelfLayerInstance.name = "Layer " + i;
            var shelfLayerScript = shelfLayerInstance.GetComponent<ShelfLayerScript>();
            shelfLayerScript.layer = i;
            shelfLayers.Add(shelfLayerInstance);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}