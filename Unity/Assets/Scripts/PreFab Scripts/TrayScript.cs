using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TrayScript : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject tray;
    public GameObject rootObject;

    private VFManager _vfManager;

    public int id;

    private int _trayWidth;
    private int _trayLength;

    public List<GameObject> cubeObjects;
    public GameObject trayObject;

    public float averageGrowth;

    void Start()
    {
        rootObject = GameObject.Find("Root");
        _vfManager = rootObject.GetComponent<VFManager>();
        _trayWidth = _vfManager.trayWidth;
        _trayLength = _vfManager.trayLength;


        //Instantiate plants as Cubes
        for (int i = 0; i < _trayWidth; i++)
        {
            for (int j = 0; j < _trayLength; j++)
            {
                var cubeInstance = Instantiate(cube, transform); //using absolute positions here, kills the parenting!!!
                cubeInstance.transform.position +=
                    new Vector3(i, 0, j) * (_vfManager.globalsize) * (1 + _vfManager.spacingPlants);
                cubeInstance.transform.position -= _vfManager.getOffset() / 2;
                cubeInstance.transform.localScale *= _vfManager.globalsize;
                cubeInstance.name = "Plant " + cubeObjects.Count;
                cubeInstance.SetActive(false);
                cubeObjects.Add(cubeInstance);
                //starting with singlecubes disabled
                //cubeInstance.SetActive(false);
            }
        }

        //Instantiate as a Tray
        var trayInstance = Instantiate(tray, transform);
        trayInstance.transform.localScale = _vfManager.getTraySize() * 1.01f;
        trayObject = trayInstance;
        trayInstance.name = "Tray";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}