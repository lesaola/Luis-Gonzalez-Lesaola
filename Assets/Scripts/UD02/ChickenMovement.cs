using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMovement : MonoBehaviour
{
    // Variables Globales

    private float _horizontal;
    private float _vertical;

    private float _speed = 1.0f;        // Variable de velocidad de movimineto
    private float _turnSpeed = 90.0f;   // Variable de velocidad de giro


    void Update()
    {

        InputPlayer(); // Para importar los keybinds del Input Manager 
        Move(); // Para mover el "transform" seleccionado
        Turn(); // Para rotar sobre el eje Y global de la escena
    }

    private void InputPlayer() 
    {    
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime); 
    }

    private void Turn()
    {
        transform.Rotate(Vector3.up * _turnSpeed * _horizontal * Time.deltaTime);
    }



}
