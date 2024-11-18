using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clcker : MonoBehaviour
{

    // Variables Globales

    [SerializeField]
    private float _thrust;
    private Rigidbody _rb;


    private void Awake()
    {

        _rb = GetComponent<Rigidbody>();

    }

    private void OnMouseDown()
    {


        _rb.AddForce(transform.up * _thrust);

    }

}
