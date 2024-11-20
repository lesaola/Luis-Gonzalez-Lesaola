using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CloneEgg : MonoBehaviour
{
    // Variables Globales

    public GameObject Egg;        // Para asignar el prefab
    public Transform  PosRotEgg;  //

    private float timeEgg = 3.0f; // Para hardcodear después



    // Update is called once per frame
    void Update()
    {
        CreateEggs();
    }

    private void CreateEggs()
    {
        if (Input.GetMouseButtonDown(0)) // Condicional al pulsar clic izquierdo 
        {
            // Instancia cada huevo:
            GameObject cloneEgg = Instantiate(Egg, PosRotEgg.position, PosRotEgg.rotation);

            Destroy(cloneEgg, timeEgg); // Harcodeamos para el timing de destrucción
        }
    }
}
