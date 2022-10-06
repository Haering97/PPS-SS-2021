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
    
    public event Action onPlusPress;
    public void plusPressed()
    {
        onPlusPress?.Invoke();
    }

    public event Action onMinusPress;

    public void minusPressed()
    {
        onMinusPress?.Invoke();
    }

}
