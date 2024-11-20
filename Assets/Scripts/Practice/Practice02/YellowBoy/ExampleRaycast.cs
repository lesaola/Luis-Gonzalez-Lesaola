using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleRaycast : MonoBehaviour
{

    // Globales

    private Ray _ray; // aqui se guarda la info del rayo
    private RaycastHit _hit; // se guarda la info de la colision "raycast-collider"
    public float RayLenght;
    public LayerMask RayMask;
    public float ForceEnemy;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        _ray.origin = transform.position;   
        _ray.direction = transform.forward; // hacia donde mira el pj

        if (Physics.Raycast(_ray, out _hit, RayLenght, RayMask)) 
        {

            Debug.Log("Estoy chocando con algo " + _hit.collider.name);
            Debug.Log("Punto de impacto: " + _hit.point);
            Debug.Log("Distancia: " + _hit.distance);
            _hit.collider.GetComponent<Rigidbody>().AddForce(Vector3.up * ForceEnemy);
        }

        Debug.DrawRay(_ray.origin, _ray.direction * RayLenght, Color.red);

    }
}
