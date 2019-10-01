using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlaneMouvement : MonoBehaviour {

    Rigidbody rb;
    public int speedFactor = 400;
    private HeliceRotation heliceRotation;


    // Use this for initialization
    void Start () {
        rb = FindObjectOfType<Rigidbody>();
        heliceRotation = GetComponentInChildren<HeliceRotation>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Jump") != 0)
        {
            rb.AddForce(new Vector3(0, Input.GetAxis("Jump") * Time.deltaTime * speedFactor, 0));
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            rb.AddForce(new Vector3(Input.GetAxis("Vertical") * Time.deltaTime * speedFactor, 0, 0));
        }

        heliceRotation.DefinirRotationSpeed(rb.velocity.magnitude);
    }
}
