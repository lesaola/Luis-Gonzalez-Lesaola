using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateMagnitude : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        Vector2 alarico = new Vector2(0.0f, 0.0f);
        Vector2 sisebuto = new Vector2(12.0f, 5.0f);

        float lenght = sisebuto.magnitude;
        Debug.Log(lenght); 

        Debug.DrawLine(alarico, sisebuto);


    }
}
