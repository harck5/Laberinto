using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 40f;
    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
            transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
    }
}
