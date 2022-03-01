using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

public class RadialTrigger : MonoBehaviour
{
    public float radius;
    public Transform target;
    private void OnDrawGizmos()
    {
        Vector3 vectorToTarget = transform.position - target.position;

        double distanceToTarget =
            Math.Sqrt(vectorToTarget.x * vectorToTarget.x + vectorToTarget.y * vectorToTarget.y);
        
        
        if (distanceToTarget <= radius)
        {
            Handles.color = Color.yellow;
        }
        else
        {
            Handles.color=Color.blue;
        }
        Handles.DrawWireDisc(transform.position,Vector3.forward, radius);
    }
}
