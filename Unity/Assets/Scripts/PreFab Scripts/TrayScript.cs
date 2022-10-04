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


        //Instantiate plants as Cubes 
        for (int i = 0; i < _trayWidth; i++)
        {
            for (int j = 0; j < _trayLength; j++)
            {
                var cubeInstance = Instantiate(cube, transform); //using absolute positions here, kills the parenting!!!
                cubeInstance.transform.position += new Vector3(i, 0, j) * (_vfManager.globalsize) * (1 + _vfManager.spacingPlants);
                cubeInstance.transform.position -= _vfManager.getOffset() / 2;
                cubeInstance.transform.localScale *= _vfManager.globalsize;
                //starting with singlecubes disabled
                cubeInstance.SetActive(true);
            }
        }
        //Instantiate as a Tray
        var trayInstance = Instantiate(cube, transform);
        trayInstance.transform.localScale = _vfManager.getTraySize() * 1.02f;
        trayInstance.SetActive(false);
        //TODO an die selbe stelle wie die cubes bewegen
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
