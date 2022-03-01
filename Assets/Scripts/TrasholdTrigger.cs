using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TrasholdTrigger : MonoBehaviour
{
   [SerializeField] private Transform target;
   [Range(-1,1)] public float trasholdDot;

    private void OnDrawGizmos()
    {
        Vector3 vectorToTarget = transform.position-target.position;
        float dir = Vector3.Dot(vectorToTarget.normalized, transform.forward.normalized);

        if ( dir< trasholdDot)
        {
            Gizmos.color=Color.green;
        }
        else
        {
             Gizmos.color=Color.red;
            
        }
        
        Gizmos.DrawLine(transform.position,transform.forward);
    }
}
