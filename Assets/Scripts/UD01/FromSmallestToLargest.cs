using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    // Introduce 3 números y que aparezcan de menor a mayor.

    //Variables Globales
    public int NumberOne,
               NumberTwo,
               NumberThree;


    // Start is called before the first frame update
    void Start()
    {

        GetSmallToLarge(NumberOne, NumberTwo, NumberThree); // Paso por parámetro para trabajar de forma local con las variables globales.


    }

    private void GetSmallToLarge(int a, int b, int c) // 3 casos distintos, con 2 posibles variaciones en cada caso. Según 'a', 'b', o 'c' sea el menor; y según sean los dos restantes. 
    {

        if (a <= b && a <= c) // Si 'a' es el menor de los 3.
        {

            if (b <= c)
            {
                Debug.Log("El orden ascendente es " + a + "," + b + "," + c); // a < (b < c) 
            }
            else
            {
                Debug.Log("El orden ascendente es " + a + "," + c + "," + b); // a < (c < b)
            }

        }



        else if (b <= a && b <= c) // Si 'b' es el menor de los 3.
        {

            if (a <= c)
            {
                Debug.Log("El orden ascendente es " + b + "," + a + "," + c); // b < (a < c)
            }
            else
            {
                Debug.Log("El orden ascendente es " + b + "," + c + "," + a); // b < (c < a)
            }
        }



        else if (c <= a && c <= b) // Si 'c' es el menor de los 3.
        {

            if (a <= b) 
            {
                Debug.Log("El orden ascendente es " + c + "," + a + "," + b); // c  < (a < b)         
            }
            else 
            {
                Debug.Log("El orden ascendente es " + c + "," + b + "," + a); // c < (b < c)                          
            }

        }
    
    }

}
