using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10f;  //añadimos velocidad
    public float rotationSpeed = 50f;  
    private float verticalInput;

    void Update()
    {
        // Obtener el input vertical del usuario
        verticalInput = Input.GetAxis("Vertical");

        // Mover el avión hacia adelante a una velocidad manejable //CAMBIAR RIGHT POR FORWARD PARA QUE DEJE DE DAR VUELTAS 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Inclinar el avión solo cuando el usuario presione las flechas arriba/abajo //CAMBIAR ROTATE POR TRANSLATE.RIGHT POT FORWARD,ROTATIONSPEED A SOLO SPEED,MANTENEMOS DELTA TIME
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
    }
}

