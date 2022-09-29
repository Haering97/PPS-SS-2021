using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfLayerScript : MonoBehaviour
{
    [SerializeField] private GameObject tray;
    public VFManager VfManager;

    private int shelfLength;
    public int id;

    // Start is called before the first frame update
    void Start()
    {
        
        VfManager = GameObject.Find("Root").GetComponent<VFManager>();
        shelfLength = VfManager.shelfLength;
        
        
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
