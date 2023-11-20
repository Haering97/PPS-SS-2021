using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public float moisture;
    public float temp;
    public float growth;

    private Vector3 calculatedGrowth;
    
    private GameObject cube;
    
    private VFManager vfManager;
    
    void Start()
    {
        cube = this.gameObject;
        vfManager = GameObject.Find("Root").GetComponent<VFManager>();
        growth = Random.Range(0.5f, 1.1f);
        calculatedGrowth = cube.transform.localScale * growth;
    }

    
    void Update()
    {
        //Die Größe des Würfels je nach Modus anzeigen.
        if (vfManager.showGrowth)
        {
            cube.transform.localScale = calculatedGrowth;
        }
        else
        {
            cube.transform.localScale = new Vector3(vfManager.globalsize,vfManager.globalsize,vfManager.globalsize);
        }
        
        //Long Press auf Würfel öffnet Menü
        
        
        
    }
}
