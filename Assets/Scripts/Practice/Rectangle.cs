using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour
{

    // Variables Globales
    private float _width,
                  _height;


    // Start is called before the first frame update
    void Start()
    {
        _width = 12.5f;
        _height = 6.1f;

        GetArea();
        GetPerimeter();
        GetDiagonal();

    }

    private void GetArea()
    {

        // Variables Locales
        float area = 0.0f;

        // Calcular el Area
        area = _width * _height;

        //Mostrar por Consola el resultado del Area
        Debug.Log("El área del rectángulo es: " + area);

    }

    private void GetPerimeter() 
    {

        //Variables Locales
        float perimeter = 0.0f;

        //Calcular perimetro
        perimeter = 2 * (_width * _height);

        //Consola perimetro
        Debug.Log("El perímetro del rectángulo es: " + perimeter);


    }


    private void GetDiagonal() 
    {

        //Variables locales
        float diagonal = 0.0f;

        //Calcular longitud de diagonal
        diagonal = Mathf.Sqrt(Mathf.Pow(_width, 2) + Mathf.Pow(_height, 2));

        //Consola diagonal
        Debug.Log("La longitud de la diagonal es: " + diagonal);
    }

}


