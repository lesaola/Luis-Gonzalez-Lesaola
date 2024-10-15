using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditional : MonoBehaviour
{

    // GLOBALES
    public int NumberOne;
    public int NumberTwo;
    public char Letter;
    public int DayNumber;

    // Start is called before the first frame update
    void Start()
    {

        IsPositive();
        IsOdd();
        IsAscendingNumber();
        IsVowel();
        IsDayWeek();
    }



    // Escribir un número, y que el programa indique si es positivo o negativo.
    private void IsPositive() 
    {
        if (NumberOne >= 0)
        {
            Debug.Log(NumberOne + " es positivo.");
        }
        else 
        {
            Debug.Log(NumberOne + " es negativo."); 
        }
        

    }



    // Escribir un número, y que el programa indique si es par o impar.
    private void IsOdd() 
    {

        if (NumberOne % 2 == 0)
        {

            Debug.Log(NumberOne + " es par.");

        }
        else 
        {

            Debug.Log(NumberOne + " es impar.");

        }
    }



    // Escribir dos números y que el programa indique si el orden es ascendiente o descendiente.
    private void IsAscendingNumber() 
    {

        if (NumberOne < NumberTwo)
        {

            Debug.Log("El orden ascendente de los números es: " + NumberOne + "\t" + NumberTwo);

        }
        else if (NumberOne == NumberTwo) 
        {

            Debug.Log("Los dos números son iguales.");
    
        }
        else 
        {

            Debug.Log("El orden ascendente de los números es: " + NumberTwo + "\t" + NumberOne);

        }

    }



    // Introduce una letra y detecta si es vocal.
    private void IsVowel() 
    {

        if (Letter == 'a' || Letter == 'e' || Letter == 'i' || Letter == 'o' || Letter == 'u' ||
            Letter == 'A' || Letter == 'E' || Letter == 'I' || Letter == 'O' || Letter == 'U')
        {

            Debug.Log(Letter + " es una vocal.");

        }

        else 
        {

            Debug.Log(Letter + " no es una vocal. ");

        }



    }
        
    // Introduce un nº del 1 al 7 y que diga el dia de la semana.
    private void IsDayWeek() 
    {

        switch (DayNumber) 
        {
            // Si son letras en vez de números en los cases,'a' con comillas simples
            case 1:
                Debug.Log("Lunes");
                break;
            case 2:
                Debug.Log("Martes");
                break;
            case 3:
                Debug.Log("Miércoles");
                break;
            case 4:
                Debug.Log("Jueves");
                break;
            case 5:
                Debug.Log("Viernes");
                break;
            case 6:
                Debug.Log("Sábado");
                break;
            case 7:
                Debug.Log("Domingo");
                break;
            default:
                Debug.Log("El número introducido no se corresponde con ningún dia de la semana");
                break;
        
        }
        
    
    }
    


}
