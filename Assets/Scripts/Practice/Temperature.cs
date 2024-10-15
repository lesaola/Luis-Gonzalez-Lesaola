using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{

    //Variables Globales
    private float _celsiusValue;
    private float _fahrenheitValue;


    // Start is called before the first frame update
    void Start()
    {

        _celsiusValue = 25f;
        _fahrenheitValue = 77f;

        GetCelsiusToFahrenheit();
        GetFahrenheitToCelsius();


    } 

    private void GetCelsiusToFahrenheit() 
    {

        //Formula de C a F:  F = (1.8 * C) + 32
        float fahrenheit = (1.8f * _celsiusValue) + 32;


        //Consola
        Debug.Log(_celsiusValue + "ºC son " + fahrenheit + "ºF");
    
    }



    private void GetFahrenheitToCelsius() 
    {
       
        // Formula de F a C: C = (F - 32) / 1.8
        float celsius = (_fahrenheitValue - 32) / 1.8f;


        //Consola
        Debug.Log(_fahrenheitValue + "ºF son " + celsius + "ºC");

    
    }


}

 
