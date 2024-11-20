using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyMovement : MonoBehaviour
{

    private float _speed = 1.5f,
                  _turnSpeed = 90.0f;

    private float _horizontal,
                  _vertical;

    private Animator anim;

    private void Awake()
    {
        //"anim" apunta (hereda) al Animator del "gameObject" que lleve este Script
        anim = GetComponent<Animator>();
    }




    // Update is called once per frame
    void Update()
    {

        InputPlayer();
        Move();
        Turn();
        Animating();
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

    private void Animating() 
    {

        if (_vertical != 0) // si el personaje se mueve
        {

            anim.SetBool("IsMoving", true);

        }
        else // _vertical = 0, ergo no se mueve
        {

            anim.SetBool("IsMoving", false);
        
        }
    }


}