using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadMov;
    public float velocidadRot;

    public bool isable;
    public GameObject huevo;


    void Start()
    {
        isable = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, velocidadMov);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -velocidadMov);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, velocidadRot, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles += new Vector3(0, -velocidadRot, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clon;
            clon = Instantiate(huevo);
            clon.transform.position = transform.position - new Vector3(0, 0, -1);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "EnablerCube"){
            isable = true;
        }
        else if (col.gameObject.name == "DisablerCube")
        {
            isable = false;
        }
    }
}
