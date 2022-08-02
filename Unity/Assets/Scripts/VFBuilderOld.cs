using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class VFBuilderOld : MonoBehaviour
{
    
    [SerializeField] private GameObject cube;

    
    [SerializeField] public int shelves;
    [SerializeField] public int shelfHeight;
    [SerializeField] public int shelfLength;
    [SerializeField] public int trayLength;
    [SerializeField] public int trayWidth;

    private int test = 10;
    
    //Classes
    
    public class VerticalFarm
    {
        public Shelf[] Shelves { get; set; }

        public VerticalFarm(int amount)
        {
            Shelves = new Shelf[amount];
            for (int i = 0; i < amount; i++)
            {
                Shelves[i] = new Shelf(4, 6);
            }
        }
        
    }

    public class Shelf
    {
        private int _height;
        private int _length;

        public Shelf(int height,int length)
        {
            var shelf = new Tray[height, length];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    shelf[i,j] = new Tray(10,10);
                    
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

        VerticalFarm myFirstFarm = new VerticalFarm(12);
        
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
