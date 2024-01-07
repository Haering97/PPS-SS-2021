using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void LayerUp()
    {
        GameEvents.current.upPressed();
    }

    public void LayerDown()
    {
        GameEvents.current.downPressed();
    }

    public void SingleCubeRender()
    {
        GameEvents.current.SCPressed();
    }
    public void RefreshData()
    {
        GameEvents.current.refresh();
    }

    public void showGrowth()
    {
        GameEvents.current.showGrowth();
    }

    public void closeUI()
    {
        GameEvents.current.closeUI();
    }

    public void showControls()
    {
        GameEvents.current.showControls();
    }
    
}
