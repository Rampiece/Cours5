using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    private Transform selfTransform;

    private void Awake()
    {
        selfTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit raycastHit;
        if (Physics.Raycast(transform.position, transform.forward, out raycastHit,
            Mathf.Infinity,~LayerMask.NameToLayer("Cube")))
        {
            Debug.Log(raycastHit.distance);
            Debug.DrawRay(selfTransform.position,selfTransform.forward * raycastHit.distance, Color.green);
        }
        else
        {
            Debug.DrawRay(selfTransform.position,selfTransform.forward * 1000, Color.red);
        }

        RaycastHit[] raycastHits = Physics.RaycastAll(selfTransform.position, selfTransform.forward);
        foreach (RaycastHit raycastHitElement in raycastHits)
        {
            Debug.Log(raycastHitElement.collider.name);
        }
    }
}
