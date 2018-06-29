using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    Vector3 originalPos;
    Vector3 targetPos;
    bool doorOpen; 

    private void Start()
    {
        originalPos = transform.position;
        targetPos = originalPos + new Vector3(0, 10, 0); 
    }

    private void Update()
    {
        if (doorOpen)
        {
            transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime); 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Door trigger");
        doorOpen = true; 

    }
}
