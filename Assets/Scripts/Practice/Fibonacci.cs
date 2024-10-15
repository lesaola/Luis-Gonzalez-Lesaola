using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonacci : MonoBehaviour
{
    // Global Values
    public int IntroducedValue; 



    // Start is called before the first frame update
    void Start()
    {

        if (GetFibonacciNumber(IntroducedValue) == -1)
        {
            Debug.Log("Introduce valor mayor a 0.");
        }
        else 
        {
            Debug.Log("La posición" + IntroducedValue + " corresponde en Fibonacci a " + GetFibonacciNumber(IntroducedValue));
        }

    }


    private int GetFibonacciNumber(int position) 
    {

        int numberOne = 0,
            numberTwo = 1;

        int addition = 0;

        if (position > 0) 
        {
            addition = numberTwo;

            for (int i = 1; i < position; i++) 
            {

                addition = numberOne + numberTwo;
                numberOne = numberTwo;
                numberTwo = addition;

            }
            return addition;
        }

        else 
        return -1; 
    
    }






}
