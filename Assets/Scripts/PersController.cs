using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersController : MonoBehaviour
{
    private float speed =10f;
    private float horizontalInput;
    private float verticalInput;
    //update para movimiento con wasd para una mejor experiencia de control junto con la camara
    void Update()
    {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
            transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
    }
}
