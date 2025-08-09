using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed = 500f;  // Velocidad giro

    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);  //Hace que gire
    }
}
