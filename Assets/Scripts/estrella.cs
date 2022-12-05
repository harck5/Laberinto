using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estrella : MonoBehaviour
{
    private float speed = 50;
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
