using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Color = System.Drawing.Color;

public class VFBuilder : MonoBehaviour
{
    [SerializeField] private GameObject cube;


    [SerializeField] public int shelves;
    [SerializeField] public int shelfHeight;
    [SerializeField] public int shelfLength;
    [SerializeField] public int trayWidth;
    [SerializeField] public int trayLength;

    static public Transform vfOrigin;

    static float spacing = 0.1f;
    static float size = 0.5f;

    static Vector3 offset;

    void Start()
    {
        Debug.Log("PP-Log: Start");
        vfOrigin = transform;

        //ist nur für global, muss am besten auch in der klasse passieren, irgednwie.
        var cubeRenderer = cube.GetComponent<Renderer>();
        cubeRenderer.sharedMaterial.SetColor("_Color", UnityEngine.Color.green);
        
        //offset hier berechnen weil ich außerhalb kein Zugriff auf Serialized Values habe.
        offset = (new Vector3((float)trayWidth / 2, 0, (float)trayLength / 2) * 0.5f);

        VerticalFarm myFirstFarm = new VerticalFarm(cube,shelves, shelfHeight, shelfLength, trayWidth, trayLength);

        Debug.Log(myFirstFarm.Shelves[0].Trays[0, 0].PlantUnits[0, 0].Humidity);

        var activeShelf = myFirstFarm.Shelves[0];

        InstantiateTray(myFirstFarm, 0, 0, 0, vfOrigin.position);

        //myFirstFarm.Shelves[0].Trays[0, 0].PlantUnits[0, 0].Instance.SetActive(false);
        //myFirstFarm.Shelves[0].Trays[0, 0].PlantUnits[2, 3].Instance.SetActive(false);

        Debug.Log("PP-Log: Finished");
    }

    void Update()
    {
    }
    
    //Classes
    
        public class VerticalFarm
    {
        public Shelf[] Shelves { get; set; }

        public VerticalFarm(GameObject prefab,int amountShelves, int shelfHeight, int shelfLength, int trayWidth, int trayLength)
        {
            Shelves = new Shelf[amountShelves];
            for (int i = 0; i < amountShelves; i++)
            {
                Shelves[i] = new Shelf(prefab,shelfHeight, shelfLength, trayWidth, trayLength);
            }
        }
    }

    public class Shelf
    {
        public Tray[,] Trays { get; set; }

        public Shelf(GameObject prefab,int shelfHeight, int shelfLength, int trayWidth, int trayLength)
        {
            Trays = new Tray[shelfHeight, shelfLength];

            for (int i = 0; i < shelfHeight; i++)
            {
                for (int j = 0; j < shelfLength; j++)
                {
                    Trays[i, j] = new Tray(prefab,trayWidth, trayLength);
                }
            }
        }
    }

    public class Tray
    {
        private int _sizex;
        private int _sizez;
        private GameObject _prefab;
        public PlantUnit[,] PlantUnits { get; set; }

        public Tray(GameObject prefab,int trayWidth, int trayLength)
        {
            _sizex = trayWidth;
            _sizez = trayLength;
            _prefab = prefab;
            PlantUnits = new PlantUnit[trayWidth, trayLength];
            for (int i = 0; i < trayWidth; i++)
            {
                for (int j = 0; j < trayLength; j++)
                {
                    PlantUnits[i, j] = new PlantUnit();
                }
            }
        }

        private void InstantiatePlants(Vector3 position)
        {
            for (int i = 0; i < _sizex; i++)
            {
                for (int j = 0; j < _sizez; j++)
                {
                    PlantUnits[i, j].Instance = Instantiate(_prefab, (new Vector3(i, 0, j) * (spacing + 0.5f) - offset)+ position,
                        Quaternion.identity);
                }
            }
        }
    }

    public class PlantUnit
    {
        public GameObject Instance { get; set; }
        public string Id { get; set; }
        public float Humidity { get; set; }
        public float GrowthFactor { get; set; } = 0;
        
        public Color Color = Color.Chartreuse;
    }

    

    void InstantiateTray(VerticalFarm farm, int shelfNumber, int trayPositionX, int trayPositionY, Vector3 position)
    {
        //TODO make grid to instaniate cubes on.
        //TODO als Methode von Tray definieren.

        var plants = farm.Shelves[shelfNumber].Trays[trayPositionX, trayPositionY].PlantUnits;
        float localXPosition;
        float localYPosition;
        float localXStart;
        float localYStart;

        for (int i = 0; i < trayWidth; i++)
        {
            for (int j = 0; j < trayLength; j++)
            {
                plants[i, j].Instance = Instantiate(cube, new Vector3(i, 0, j) * (spacing + 0.5f) - offset,
                    Quaternion.identity);
            }
        }
    }

    
    
    void InstantiateVF()
    {
    }
}