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
    [SerializeField] public int shelfLenth;

    [SerializeField] public int trayLength;
    [SerializeField] public int trayWidth;
    
    
    //Classes
    /*
    
    public class VerticalFarm
    {
        private Shelf[] _shelves;

        public VerticalFarm(int amount)
        {
            _shelves = InitializeArray<Shelf>(100);

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
    
    */
    
    
    
    
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

    
    T[] InitializeArray<T>(int length) where T : new()
    {
        T[] array = new T[length];
        for (int i = 0; i < length; ++i)
        {
            array[i] = new T();
        }

        return array;
    }
}
