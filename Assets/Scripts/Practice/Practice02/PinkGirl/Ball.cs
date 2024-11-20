using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    
    public Material Mat;



    /*private void OnCollisionEnter(Collision infoCollision) 
    {

        Debug.Log("he colisionado con" + infoCollision.gameObject.name);


        // Ver si choco contra cubo. Accedo a collider del target y comprueba la ETIQUETA

        if (infoCollision.collider.CompareTag("Enemy"))
        { 
        
               //cambiamos material del cubo. accedememos al componente RENDERER y propiedad MATERIAL

               infoCollision.gameObject.GetComponent<Renderer>().material = Mat;

        }

    }*/

    private void OnTriggerEnter(Collider infoAccess)
    {

        Debug.Log("Estoy haciendo una colision TRIGGER con: " + infoAccess.gameObject.name);

        //identificamos con etiqueta el objeto contra el que choca
        if (infoAccess.CompareTag("Enemy")) 
        { 
        
            //ese "infoAccess.gameObject" hace referencia al cubo
            Destroy(infoAccess.gameObject);
        
        }

    }

}
