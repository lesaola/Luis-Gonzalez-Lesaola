using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activated : MonoBehaviour
{
    // Globales
    public GameObject myCamera;




    private void Start()
    {
        
        gameObject.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {

        ActivatedCamera();

    }


    private void ActivatedCamera()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            myCamera.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.E))
        {

            myCamera.SetActive(true);

        }
    
    }
}
