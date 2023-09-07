using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 30.0f;
    //public GameObject propeller;
    //public float torque = 50.0f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         //transform.Rotate(rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
}
