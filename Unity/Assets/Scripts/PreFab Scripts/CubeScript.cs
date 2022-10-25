using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public float moisture;
    public float temp;
    public float growth;

    private VFManager vfManager;
    
    void Start()
    {
        vfManager = GameObject.Find("Root").GetComponent<VFManager>();

        growth = Random.Range(0.8f, 1f);
    }

    
    void Update()
    {
        
    }
}
