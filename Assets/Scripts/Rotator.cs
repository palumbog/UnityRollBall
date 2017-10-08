using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float xRotation, yRotation, zRotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 rotation = new Vector3(xRotation, yRotation, zRotation) * Time.deltaTime;
        transform.Rotate(rotation);
	}
}
