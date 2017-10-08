using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    //FixedUpdate is called before making any phisycal calulation
    void FixedUpdate()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        
        float y = 0.0f;

        Vector3 movement = new Vector3(inputHorizontal,y,inputVertical);
        rb.AddForce(movement*speed);
    }
}
