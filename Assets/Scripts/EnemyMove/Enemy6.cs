using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy6 : MonoBehaviour
{
    private float speed = 40f;
    private float turnSpeed = 40f;
    private float up = 11f;
    private float down = -48f;
    private Vector3 palante = Vector3.forward;
    private Vector3 rota = new Vector3(0, 180, 0);
    void Update()
    {
        transform.Translate(palante * speed * Time.deltaTime);
        if (transform.position.z >= up)
        {
            transform.Rotate(rota);
        }
        if (transform.position.z <= down)
        {
            transform.Rotate(rota);
        }
    }
}
