using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float speed = 100f;
    private float turnSpeed = 100f;
    private float horizontalInput;

    void Update()
    {

        horizontalInput = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * speed * Time.deltaTime * horizontalInput);
    }
}
