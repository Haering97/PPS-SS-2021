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

        public VerticalFarm(int amount, int shelfHeight, int shelfLength, int trayLength,int trayWidth)
        {
            Shelves = new Shelf[amount];
            for (int i = 0; i < amount; i++)
            {
                Shelves[i] = new Shelf(shelfHeight,shelfLength, trayLength, trayWidth);
            }
        }
    }

    public class Shelf
    {
        public Tray[] Trays { get; set; }

        public Shelf(int shelfheight, int shelflength, int trayLength, int trayWidth)
        {
            var shelf = new Tray[shelfheight, shelflength];
            for (int i = 0; i < shelfheight; i++)
            {
                for (int j = 0; j < shelflength; j++)
                {
                    shelf[i, j] = new Tray(trayLength, trayWidth);
                }
            }
        }
    }

    public class Tray
    {
        public PlantUnit[,] PlantUnits { get; set; }

        public Tray(int width, int length)
        {
           PlantUnits  = new PlantUnit[width, length];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    PlantUnits[i, j] = new PlantUnit();
                }
            }
        }
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

        VerticalFarm myFirstFarm = new VerticalFarm(shelves, shelfHeight, shelfLength, trayLength, trayWidth);
        
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