using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gizmo : MonoBehaviour
{
    [SerializeField] private float size;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.gray;
        Gizmos.DrawCube(transform.position, new Vector3(size, size, size));
    }
    
    
}