using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFBuilder : MonoBehaviour
{
    
    [SerializeField] private GameObject cube;
    
    void Start()
    {
        Debug.Log("PP-Log: VFBuilder instantiate cube");
        Instantiate(cube,this.transform);
    }
    
    void Update()
    {
        
    }

}
