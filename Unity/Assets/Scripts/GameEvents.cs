using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action onSCPress;

    public void SCPressed()
    {
        onSCPress?.Invoke();
    }

    public event Action onUpPress;

    public void upPressed()
    {
        onUpPress?.Invoke();
    }

    public event Action onDownPress;

    public void downPressed()
    {
        onDownPress?.Invoke();
    }

    public event Action onDataRefresh;

    public void refresh()
    {
        onDataRefresh?.Invoke();
    }

    public event Action onSGPress;

    public void showGrowth()
    {
        onSGPress?.Invoke();
    }
    
    public event Action onClosePress;

    public void closeUI()
    {
        onClosePress?.Invoke();
    }
    
}