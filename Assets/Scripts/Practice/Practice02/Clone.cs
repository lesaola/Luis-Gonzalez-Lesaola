using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
    // Globales
    public GameObject Acorn;
    public Transform PosRotAcorn;

    public float thrustY,
                 thrustZ;

    private float timeAcorn = 3.0f; // hardcode

    //private float timeInvoke = 2.0f;
   // private float timeRepeating = 4.0f;

    private void Start()
    {

        //Invoke("CreateAcorns", timeInvoke);
        //InvokeRepeating("CreateAcorns", timeInvoke, timeRepeating);
    }


    void Update()
    {

        CreateAcorns();

    }

    private void CreateAcorns() 
    {

        if (Input.GetMouseButtonDown(0)) // "si Clic izquierdo"
        {
            // Crear clones del prefabricado de la bellota
            //  <Como no le indico donde quiero que genere el clon, 
            //  se crea en la posición (0.0f, 0.0f, 0.0f)>
            GameObject cloneAcorn = Instantiate(Acorn, PosRotAcorn.position, PosRotAcorn.rotation);

            //Obtengo el componente Rigidbody de cada bellota
            Rigidbody rbAcorn = cloneAcorn.GetComponent<Rigidbody>();

            //Vector3.up hace referencia al eje Y de la escena
            rbAcorn.AddForce(Vector3.up * thrustY);

            //transform.forward hace referencia al eje Z local de PosRotAcorn
            rbAcorn.AddForce(transform.forward * thrustZ);

            Destroy(cloneAcorn, timeAcorn); // "HardCodear"
            //Destroy(this);
        }

    }
}
