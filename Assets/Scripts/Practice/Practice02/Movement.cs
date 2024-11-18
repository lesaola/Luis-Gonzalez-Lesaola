using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    // Variables Globales
    [SerializeField]
    private float _speed = 0.8f;
    [SerializeField]
    private float _turn = 90.0f;

    //public Space MySpace;
    //public ForceMode MyForceMode;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W)) 
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S)) 
        {

            transform.Translate(Vector3.back * _speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(-Vector3.up * _turn * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(Vector3.up * _turn * Time.deltaTime);

        }
        
        //transform.Rotate(Vector3.up * _turn * Time.deltaTime);

    }
}
