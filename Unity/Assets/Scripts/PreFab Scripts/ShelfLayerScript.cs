using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfLayerScript : MonoBehaviour
{
    [SerializeField] private GameObject tray;

    public int id;
    public int shelfLength;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < shelfLength; i++)
        {
            var trayInstance = Instantiate(tray, transform);
            var trayScript = trayInstance.GetComponent<TrayScript>();
            //TODO stat durchscleifen daten vom Manager beziehen.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
