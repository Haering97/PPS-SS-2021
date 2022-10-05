using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfLayerScript : MonoBehaviour
{
    [SerializeField] private GameObject tray;
    private GameObject rootObject;

    private VFManager _vfManager;
    private int _shelfLength;
    public int layer;
    public int id;

    public List<GameObject> trays;
    public List<TrayScript> traysScripts;
    

    // Start is called before the first frame update
    void Start()
    {
        rootObject = GameObject.Find("Root");
        _vfManager = rootObject.GetComponent<VFManager>();
        _shelfLength = _vfManager.shelfLength;


        for (int i = 0; i < _shelfLength; i++)
        {
            var trayInstance = Instantiate(tray, transform);
            trayInstance.transform.position += new Vector3(0, 0, i) * _vfManager.getSpacingTraysDynamic();
            trayInstance.name = "Tray " + i;
            var trayScript = trayInstance.GetComponent<TrayScript>();
            trayScript.id = i;
            trayScript.layer = layer;
            traysScripts.Add(trayScript);
            trays.Add(trayInstance);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}