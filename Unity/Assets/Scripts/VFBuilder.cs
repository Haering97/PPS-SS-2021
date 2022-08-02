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
        private Shelf[] _shelves;

        public VerticalFarm(int amount)
        {
            _shelves = new Shelf[amount];
        }
        
    }

    public class Shelf
    {
        private int _height;
        private int _length;
        private Tray[,] _shelf;

        public Shelf(int height, int length)
        {
            _shelf = new Tray[height, length];
        }
        
    }
    
    public class Tray
    {
        private SinglePlantUnit[,] _tray;
        
        public Tray(int sizeX,int sizeY)
        {
            _tray  = new SinglePlantUnit[sizeX,sizeY];
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
        Debug.Log("PP-Log: VFBuilder instantiate cube Patch");
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
