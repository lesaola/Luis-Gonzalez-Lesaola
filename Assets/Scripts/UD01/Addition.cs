using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{

    // Globales
    public int IntroducedValue;


    // Start is called before the first frame update
    void Start()
    {
       
      GetAddition(IntroducedValue);  

    }

    private void GetAddition(int value) 
    {

        int addition = 0; // Variable local para que la suma se guarde

        for (int i = 0; i < value; i++) 
        {
            addition = addition + i; 
        }

        Debug.Log("La suma de los números del 1 al " + value + " sería: " + addition);
    
    }




}
