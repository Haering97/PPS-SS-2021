using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class VFBuilder : MonoBehaviour
{
    
    [SerializeField] private GameObject cube;

    [SerializeField] public int traySizeX;
    [SerializeField] public int traySizeY;
    
    public class VerticalFarm
    {
        
    }

    public class PlantTray
    {
        private int _sizeX;
        private int _sizeY;

        public PlantTray(int sizeX,int sizeY)
        {
            _sizeX = sizeX;
            _sizeY = sizeX;
        }
    }

    public class SinglePlantUnit
    {
        
    }
    
    void Start()
    {
        Debug.Log("PP-Log: VFBuilder instantiate cube");
        Instantiate(cube,this.transform);
    }
    
    void Update()
    {
        
    }

}
