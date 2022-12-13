using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    private int starCounter;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("estrella"))
        {
            Destroy(other.gameObject);
            starCounter++;
            Debug.Log(message: $"Has conseguido {starCounter} estrellas");

        }
        if (other.gameObject.name.Contains("enemy"))
        {
            Destroy(gameObject);
            Debug.Log(message: $"HAS PERDIDO!!");
        }
        if (starCounter == 50)
        {
            Debug.Log(message: $"HAS GANADO!!");
        }
    }
}
