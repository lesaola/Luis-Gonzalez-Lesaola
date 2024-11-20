using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class AttackFlower : MonoBehaviour
{

    // Variables Globales

    private Animator anim; // Para la animaci�n

    public GameObject Flower; // Para instanciar, lanzar y destruir las flores
    public Transform PosRotFlower;

    public float thrustY,
                 thrustZ;

    private float timeFlower = 5.0f; // Hardcodear la destrucci�n de flores

     

    // Comienzo con la animaci�n para encontrar los frames clave para los spawn
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // M�todos para la animaci�n
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) // Condicional clic izquierdo
        {
            Throw();
        }
    }
    private void Throw()
    {
        anim.SetTrigger("Throw"); // Ejecuta la animaci�n
    }

    // Seguimos con la instancia de las flores
    private void CreateFlowers()
    {
        GameObject cloneFlower = Instantiate(Flower, PosRotFlower.position, PosRotFlower.rotation);

        Rigidbody rbFlower = cloneFlower.GetComponent<Rigidbody>();

        rbFlower.AddForce(Vector3.up * thrustY);
        rbFlower.AddForce(transform.forward * thrustZ);

        Destroy(cloneFlower, timeFlower); // las destruimos con el tiempo hardcodeado
    }

    

}
