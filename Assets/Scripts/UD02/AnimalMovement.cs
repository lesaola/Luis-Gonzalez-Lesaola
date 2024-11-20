using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    // Variables Globales

    private float _speed = 1.5f,    // para movimiento
                  _turnSpeed = 90.0f;
    private float _horizontal,
                  _vertical;

    private Animator _anim;         // para animaci�n
    private Rigidbody _rb;
    
    public LayerMask GroundMask;    // para raycast de salto
    public float RayLenght;
    public float JumpForce;

    private Ray _ray;            
    private RaycastHit _hit;

    private bool _isGrounded,       // para saltar
                 _canPlayerJump;




    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        InputPlayer();
        Move();
        Turn();
        Animating();
        CanJump();
    }

    private void FixedUpdate()
    {
        LaunchRaycast();

        if (_canPlayerJump) 
        {
            
            _canPlayerJump = false;
            Jump();
        }
    }

    // Para comprobar si es posible el salto
    private void LaunchRaycast() 
    {
        _ray.origin = transform.position;
        _ray.direction = -transform.up;

        if (Physics.Raycast(_ray, out _hit, RayLenght, GroundMask))
        {
            _isGrounded = true;
            _anim.SetBool("IsJumpingBool", false); // desactivar animaci�n
        }
        else
        { 
            _isGrounded = false;
        }
        
    }

    private void CanJump() 
    {

        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded) 
        {
            _canPlayerJump = true;      
        }
    }

    private void Jump() 
    {
        _rb.AddForce(Vector3.up * JumpForce); // aplica la fuerza de salto
        _anim.SetBool("IsJumpingBool", true); // activa la animaci�n del salto
    }


    // Volvemos a crear los m�todos para asignar inputs, traslaci�n y rotaci�n
    // como en el anterior ejercicio:

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

    // Creamos m�todo para la animaci�n de movimiento adelante/atr�s
    private void Animating()
    {

        if (_vertical > 0) // Movimiento hacia adelante
        {
            _anim.SetBool("IsMoving", true);
        }

        else if (_vertical < 0) // Movimiento hacia atr�s
        {
            _anim.SetBool("IsMovingBack", true);
        }

        else // _vertical = 0, ergo no se mueve
        {
            _anim.SetBool("IsMoving", false);
            _anim.SetBool("IsMovingBack", false);
        }

        
    }
}
