using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estrella : MonoBehaviour
{
    //Mantener una rotacion continua
    private float speed = 100;
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
