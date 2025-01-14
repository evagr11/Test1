using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public int Speed = 1;
    private Vector3 address;
    private float xBound = 11.24f;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(0, 0, 0); 
    }

    void Update()
    {
        
        address = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.D))
        {
            address += Vector3.right;
        }

        if (transform.position.x >= xBound)
        {
            gameObject.transform.position = new Vector3(-xBound, 0, 0);
        }

        gameObject.transform.position += address * Speed * Time.deltaTime;
    }
}