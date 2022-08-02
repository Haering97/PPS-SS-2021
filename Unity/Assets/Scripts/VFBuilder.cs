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
        public Shelf[] Shelves { get; set; }
        /*
        public VerticalFarm(int amount)
        {
            Shelves = new Shelf[amount];
            for (int i = 0; i < amount; i++)
            {
                Shelves[i] = new Shelf(4, 6);
            }
        }
        */
    }

    public class Shelf
    {
        public Tray[] Trays { get; set; }
        /*
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
        */
    }
    
    public class Tray
    {
        public PlantUnit[,] PlantUnits { get; set; }
        /*
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
        }*/
    }

    public class PlantUnit
    {
        public float Humidity { get; set; }
        public float GrowthFactor { get; set; } = 0;
    }






    void Start()
    {

        Debug.Log("PP-Log: VFBuilder instantiate cube Patch");
        Instantiate(cube, this.transform);

        VerticalFarm myFirstFarm = new VerticalFarm();
        myFirstFarm.Shelves = new Shelf[shelves];

        for (int i = 0; i < shelves; i++)
        {
            myFirstFarm.Shelves[i] = new Shelf();
        }
            
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
