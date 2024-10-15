using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Variables Globales
    public int Number;
    
    // Start is called before the first frame update
    void Start()
    {

        //GetNumbers0To100();
        //GetNumbers0To100For();
        GetNumbers100To0While();
        GetNumbers1ToNumberFor();
    }

    private void GetNumbers0To100() 
    {

        // Crear variable de incremento
        int i = 0;

        // Crear el WHILE
        while (i < 101) 
        {
            Debug.Log(i);
            i++; // i + 1

        }
    
    }

    private void GetNumbers0To100For() 
    { 
    
        for(int i=0; i<101; i++) 
        {

            Debug.Log(i);

        }

    }

    private void GetNumbers100To0While() 
    {

        int i = 100;

        while (i > -1) 
        {

            Debug.Log(i);
            i--;
        
        }
    
    
    }

    private void GetNumbers1ToNumberFor() 
    {

        for (int i = 1; i <= Number; i++) 
        {

            Debug.Log(i);
        
        }
    
    
    }


}

