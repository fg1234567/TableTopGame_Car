using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CarMovemement : MonoBehaviour {

    public Rigidbody car;
    public GameObject Roadgameobject;

    public float forwardForce = 50f;
    public float sideForce = 25f;
    public float jumpForce = 20f;


    private void Start()
    {
        Roadgameobject.transform.position = new Vector3(0.00f, -0.11f, 2.26f);
    }

    void FixedUpdate () {

        Vector3 currentPos = car.transform.position;

        float restrictionX = Mathf.Clamp(currentPos.x, 0.00f, 3.00f);

        if(restrictionX == currentPos.x)
        {
            currentPos.x = restrictionX;
            car.transform.position = currentPos;
        }

        /*if( car.transform.position.x < -0.40f)
        {
            Vector3 updatePos = car.transform.position;
            updatePos.x = -0.39f;
            car.transform.position = updatePos;
        }

        else if ( car.transform.position.x > 3.00f)
        {
            Vector3 updatePos = car.transform.position;
            updatePos.x = 2.99f;
            car.transform.position = updatePos;
        }*/


        if (Input.GetKey("d"))
        {
            car.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            car.AddForce((-1) * sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        Roadgameobject.transform.position = new Vector3(0.00f, -0.11f, (-1) * Time.time);

    }
    /*
    void OnCollisionEnter(Collision collider)
    {
        if (Collision.collider.tag == "Obstacle")
        {
            //this.enabled = false;
            Destroy(collider.gameObject);

        }
    }*/


}
