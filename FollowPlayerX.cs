using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // Guarda la distancia inicial entre la cámara y el avión
        offset = transform.position - plane.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Mantiene la cámara a la misma distancia relativa del avión
        transform.position = plane.transform.position + offset;
    }
}

