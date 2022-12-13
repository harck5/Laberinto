using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebas : MonoBehaviour
{

    public bool Ofb;
    public float x;
    public float y;
    public float z;

    private bool OutOfBounds(float limitX, float limitY, float limitZ)
    {
        if (transform.position.x <= limitX &&  transform.position.y <= limitY &&  transform.position.z <= limitZ)
        {
            return  true;
        }
        if(transform.position.x >= (-1 * limitX) && transform.position.y >= (-1 * limitY) && transform.position.z >= (-1 * limitZ))
        {
            return  true;
        }
        else
        {
            return false;
        }
    }

    private void Start()
    {

        OutOfBounds(x, y, z);

        if (OutOfBounds(x,y,z) == true)
        {
            Debug.Log("The object it's not out of bounds");
        }
        else
        {
            Debug.Log("The object it's out of bounds");
        }


    }
}
