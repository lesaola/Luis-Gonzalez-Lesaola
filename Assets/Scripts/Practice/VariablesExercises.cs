using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesExercises : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

        // variable LOCAL (ausencia de public o private, EN CAMEL CASE)
        float x;
        x = 2.0f;
        x = Mathf.Pow((x + x), 2);
        x = Mathf.Sqrt(x + Mathf.Sqrt(x) + 5);
        Debug.Log(x); 


    }

    // Update is called once per frame
    void Update()
    {
        // variable LOCAL
        float x; 
        
    }
}
