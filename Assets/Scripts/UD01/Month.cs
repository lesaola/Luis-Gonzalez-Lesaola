using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    // Introduce un nº del 1 al 12, y muestra el nombre del mes correspondiente.

    // Valores Globales
    public int MonthNumber;
    
    
    // Start is called before the first frame update
    void Start()
    {

        GetMonth();

    }


    private void GetMonth() 
    {

        switch(MonthNumber) 
        {

            case 1:
                Debug.Log("El 1 corresponde con Enero.");
                break;
            case 2:
                Debug.Log("El 2 corresponde con Febrero.");
                break;
            case 3:
                Debug.Log("El 3 corresponde con Marzo.");
                break;
            case 4:
                Debug.Log("El 4 corresponde con Abril.");
                break;
            case 5:
                Debug.Log("El 5 corresponde con Mayo.");
                break;
            case 6:
                Debug.Log("El 6 corresponde con Junio.");
                break;
            case 7:
                Debug.Log("El 7 corresponde con Julio.");
                break;
            case 8:
                Debug.Log("El 8 corresponde con Agosto.");
                break;
            case 9:
                Debug.Log("El 9 corresponde con Septiembre.");
                break;
            case 10:
                Debug.Log("El 10 corresponde con Octubre.");
                break;
            case 11:
                Debug.Log("El 11 corresponde con Noviembre.");
                break;
            case 12:
                Debug.Log("El 12 corresponde con Diciembre.");
                break;
       
        
        }
    
    
    }



}
