using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void ZoomBigger()
    {   
        Debug.Log("PP-Log: send Event");
        GameEvents.current.plusPressed();
    }

    public void ZoomSmaller()
    {
        
    }
}
