using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollarsToEuros : MonoBehaviour
{

    // Variables Globales
    private float _euro;
    public float Dollar;
    
    // Start is called before the first frame update
    void Start()
    {

        _euro = 0.90f;
        Debug.Log(GetDollarToEuro());

    }


    // Metodo de RETURN
    private float GetDollarToEuro() 
    
    {

        // Variables locales
        float conversion = 0.0f;


        // Calculo de conversion
        conversion = Dollar * _euro;


        // Devolver valor tipo float
        return conversion;


    
    }
    
}
