using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysExercises : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetPositiveNumbers();   
    }

    private void GetPositiveNumbers() 
    {

        int[] numbersArray = new int[10] {24, -56, 8, 12, -54, 34, -26, -87, 93, 0};
        //int[] numbersArray = {24, 56, 8, 12, 54, 34, 26, 87, 93, 0}

        for (int i = 0; i < numbersArray.Length; i++) 
        {

            if (numbersArray[i] >= 0) 
            {
                Debug.Log(numbersArray[i]); // La i recorre el array
            }
        
        }


    }


}
