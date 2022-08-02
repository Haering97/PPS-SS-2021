using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class VFBuilder : MonoBehaviour
{
    
    [SerializeField] private GameObject cube;

    
    [SerializeField] public int shelves;
    [SerializeField] public int shelfHeight;
    [SerializeField] public int shelfLength;
    [SerializeField] public int trayLength;
    [SerializeField] public int trayWidth;
    
    //Classes
    
    public class VerticalFarm
    {
        public List<Shelf> Shelves { get; set; }

        public VerticalFarm(int amount)
        {
            Shelves = new List<Shelf>();
        }
        
    }

    public class Shelf
    {
        private int _height;
        private int _length;
        private Tray[,] _shelf;

        public Shelf(int heigth,int length)
        {
            _shelf = new Tray[heigth, length];
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    _shelf[i,j] = new Tray(10,10);
                    
                }
                //OuterLoop
            }
        }
        
    }
    
    public class Tray
    {
        private SinglePlantUnit[,] _tray;
        
        public Tray(int width,int length)
        {
            _tray = new SinglePlantUnit[width, length];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    _tray[i,j] = new SinglePlantUnit(12,80);
                    
                }
                //OuterLoop
            }
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

        Debug.Log("afterCreation");
        
        
        
        
        
        
        
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
