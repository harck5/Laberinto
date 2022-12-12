using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersController : MonoBehaviour
{
    private float speed =10f;
    private float horizontalInput;
    private float verticalInput;
    public GameObject projectailePrefab;
    public int starCounter;

    void Update()
    {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
            transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
    }
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
