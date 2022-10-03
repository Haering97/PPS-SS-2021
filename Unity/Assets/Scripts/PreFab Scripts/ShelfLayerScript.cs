using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfLayerScript : MonoBehaviour
{
    [SerializeField] private GameObject tray;
    public GameObject rootObject;

    private VFManager _vfManager;
    private int _shelfLength;
    public int id;

    // Start is called before the first frame update
    void Start()
    {
        
        _vfManager = rootObject.GetComponent<VFManager>();
        _shelfLength = _vfManager.shelfLength;
        
        
        for (int i = 0; i < _shelfLength; i++)
        {
            var trayInstance = Instantiate(tray, transform);
            var trayScript = trayInstance.GetComponent<TrayScript>();
            trayScript.id = i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
