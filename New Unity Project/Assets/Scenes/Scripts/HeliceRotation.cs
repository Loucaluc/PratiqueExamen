using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliceRotation : MonoBehaviour {

    // Use this for initialization
    private float rotationSpeed = 0;
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        gameObject.transform.Rotate(new Vector3(0, 0, Time.deltaTime * rotationSpeed * 1000));
    }

    public void DefinirRotationSpeed(float vitesse)
    {
        rotationSpeed = vitesse;
    }
}
