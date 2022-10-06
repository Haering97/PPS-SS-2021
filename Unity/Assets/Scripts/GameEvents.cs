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

}
