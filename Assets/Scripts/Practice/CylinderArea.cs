using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderArea : MonoBehaviour
{

    //Variables Globales
    private float _radius,
                  _height;



    // Start is called before the first frame update
    void Start()
    {

        _radius = 5f;
        _height = 15.5f;

        GetArea();
        GetVolume();



    }


    private void GetArea() 
    {

        // Variables locales
        float area = 0.0f;

        // Constante para saber Pi
        float pi = Mathf.PI; 

        // Formula Area de las Bases
        float areaBases = 2 * pi * Mathf.Pow(_radius, 2);

        // Formula Area Lateral
        float areaLateral = 2 * pi * _radius * _height;

        // Area Total
        float totalArea = areaBases + areaLateral;

        // Consola Area Total
        Debug.Log("El área total del cilindro es de: " + totalArea);
      

    
    }


    private void GetVolume() 
    {

        //Variables locales
        float volume = 0.0f;
        float pi = Mathf.PI;

        // Formula del Volumen de Cilindro (pi*r^2*h)
        volume = pi * Mathf.Pow(_radius, 2) * _height;
    
        //Consola Volumen
        Debug.Log("El volumen del cilindro es de: " +  volume);
    }



}

