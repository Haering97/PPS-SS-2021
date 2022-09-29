using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayScript : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    public VFManager VfManager;

    public int id;

    private int trayWidth;
    private int trayLength;
    
    void Start()
    {
        VfManager = GameObject.Find("Root").GetComponent<VFManager>();
        trayWidth = VfManager.trayWidth;
        trayLength = VfManager.trayLength;

        for (int i = 0; i < trayWidth; i++)
        {
            for (int j = 0; j < trayLength; j++)
            {
                var cubeInstance = Instantiate(cube, transform);
                
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
