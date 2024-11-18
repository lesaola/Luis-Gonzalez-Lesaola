using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAxis : MonoBehaviour
{

    // Variables Globales
    private float _horizontal;
    private float _vertical;
    private float _speed = 3.0f;
    private float _turnSpeed = 90.0f;

    // Update is called once per frame
    void Update()
    {

        InputCube();

    }

    private void InputCube() 
    {

        // Teclas A y D y flechas < y > se van a usar
        _horizontal = Input.GetAxis("Horizontal");

        // Flechas arriba y abajo y W y S se van a usar
        _vertical = Input.GetAxis("Vertical");

        //Aplicamos el valor del eje vertical a "translate"
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);
    
        //Aplicamos el valor del eje horizontal al "rotate"
        transform.Rotate(Vector3.up * _horizontal * _turnSpeed *  Time.deltaTime);

    }


}
