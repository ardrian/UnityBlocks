using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    float moveSpeed = 5.0f;
    float rotationSpeed = 10.0f;
    bool openDoor = true; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        //Vector3 position = transform.position;
        //transform.position = transform.position + transform.forward * moveY * moveSpeed * Time.deltaTime;

        Vector3 rotation = transform.eulerAngles;
        rotation.y += rotationSpeed * moveX * Time.deltaTime;
        transform.rotation = Quaternion.Euler(rotation); 

        Vector3 moveVector = transform.forward * moveY * moveSpeed;
        GetComponent<CharacterController>().SimpleMove(moveVector);
    }

    
}
