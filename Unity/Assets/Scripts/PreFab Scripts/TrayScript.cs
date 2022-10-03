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
    
    
    static float spacingPlants = 0.1f;
    
    static float globalsize = 1f;
    
    void Start()
    {
        _vfManager = rootObject.GetComponent<VFManager>();
        _trayWidth = _vfManager.trayWidth;
        _trayLength = _vfManager.trayLength;

        for (int i = 0; i < _trayWidth; i++)
        {
            for (int j = 0; j < _trayLength; j++)
            {
                var cubeInstance = Instantiate(cube, transform); //using absolute positions here, kills the parenting!!!
                cubeInstance.transform.position += new Vector3(i, 0, j) * (globalsize + spacingPlants);
                cubeInstance.transform.localScale *= globalsize;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
