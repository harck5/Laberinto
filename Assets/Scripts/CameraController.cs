using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Script creado para el manejo de la rotacion de la camara
    //Esta creado a parte del jugador para que este mas ordenado y facil visivilidad
    private float speedcam = 5f;
    private float horizontalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * speedcam * horizontalInput);
    }
}
