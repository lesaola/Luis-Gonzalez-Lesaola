using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyAttack : MonoBehaviour
{
    // Globales
    private Animator anim;

    public Collider ColliderAttack; // collider de la espada



    private void Awake()
    {
        anim = GetComponent<Animator>();
    }



    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }

    }
    private void Attack() 
    {
        //ejecutar la animación
        anim.SetTrigger("Attack");  
    }


    private void EnableCollider() 
    {
    
        //habilitar el componente para que actue el collider en escena
        ColliderAttack.enabled = true;
    
    }

    private void DisableCollider()
    {
    
        ColliderAttack.enabled = false; //deshabilitar el componente
    
    }

}
