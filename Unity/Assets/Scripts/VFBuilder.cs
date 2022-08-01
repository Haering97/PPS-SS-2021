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
        private Shelf[] Shelves { get; set; }
    }

    public class Shelf
    {
        private int _height;
        private int _length;
    }
    
    public class Tray
    {
        private int _sizeX;
        private int _sizeY;
        private SinglePlantUnit[][] _plantUnits;
        
        public Tray(int sizeX,int sizeY)
        {
            _sizeX = sizeX;
            _sizeY = sizeY;
        }
    }

    public class SinglePlantUnit
    {
        public SinglePlantUnit(float humidity, float growthFactor)
        {
            Humidity = humidity;
            GrowthFactor = growthFactor;
        }

        public float Humidity { get; set; }
        public float GrowthFactor { get; set; } = 0;
    }
    
    
    
    void Start()
    {
        Debug.Log("PP-Log: VFBuilder instantiate cube");
        Instantiate(cube,this.transform);
        
    }
    
    void Update()
    {
        
    }

    void constructVF()
    {
        
    }

    void instantiateVF()
    {
        
    }

}
