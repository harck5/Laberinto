using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy5 : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 20f;
    private float up = 31f;
    private float down = 10f;
    private Vector3 palante = Vector3.forward;
    private Vector3 rota = new Vector3(0, 180, 0);
    void Update()
    {
        transform.Translate(palante * speed * Time.deltaTime);
        if (transform.position.x >= up)
        {
            transform.Rotate(rota);
        }
        if (transform.position.x <= down)
        {
            transform.Rotate(rota);
        }
    }
}
