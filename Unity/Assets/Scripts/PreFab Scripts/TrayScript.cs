using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayScript : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    public GameObject rootObject;

    private VFManager _vfManager;

    public int id;

    private int _trayWidth;
    private int _trayLength;
    
    void Start()
    {
        _vfManager = rootObject.GetComponent<VFManager>();
        _trayWidth = _vfManager.trayWidth;
        _trayLength = _vfManager.trayLength;

        for (int i = 0; i < _trayWidth; i++)
        {
            for (int j = 0; j < _trayLength; j++)
            {
                var cubeInstance = Instantiate(cube, transform);
                
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
