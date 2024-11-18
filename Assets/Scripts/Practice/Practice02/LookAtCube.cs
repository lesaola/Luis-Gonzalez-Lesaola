using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCube : MonoBehaviour
{

    // Variables Globales
    public Transform MyCube;



    // Update is called once per frame
    void Update()
    {

        TransformLook();
    }

    private void TransformLook() 
    {
    
        transform.LookAt(MyCube);
    
    }


}

