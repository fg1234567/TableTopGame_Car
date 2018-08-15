using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImprovedCarMovement : MonoBehaviour {

    public Rigidbody car;

    public float forwardForce = 5f;
    public float sideForce = 2.50f;

    void Start () {


    }
	
	void Update () {

        if (Input.GetKey("w"))
        {
            car.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            car.AddForce((-1) * sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            car.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            car.AddForce(0, 0, (-1) * forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

    }
}
