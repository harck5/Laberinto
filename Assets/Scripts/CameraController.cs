using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float speedcam = 5f;
    private float turnSpeed = 50f;
    private float horizontalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * speedcam * horizontalInput);
    }
}
