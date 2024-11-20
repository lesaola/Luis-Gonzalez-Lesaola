using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlAttack : MonoBehaviour
{

    // Globales
    public GameObject Ball;      // creamos espacio para arrastrar GameObject
    public Transform PosRotBall; // creamos espacio para Spawnear la bola
    private float _thrustY = 100.0f, 
                  _thrustZ = 300.0f; // para hardcodear después
    private float _timeBall = 5.0f; 
    

    // Update is called once per frame
    void Update()
    {
        CreateBalls(); // llamamos método
           
    }

    private void CreateBalls()
    {

        if (Input.GetMouseButtonDown(0))
        {

            //1 - INSTANCIAMOS
            GameObject cloneBall = Instantiate(Ball, PosRotBall.position, PosRotBall.rotation);

            Rigidbody rbBall = cloneBall.GetComponent<Rigidbody>();//2 - añadimos rigidbody a los clones

            //Vector3.up hace referencia al eje Y GLOBAL de la escena \
            rbBall.AddForce(Vector3.up * _thrustY);//                  3 - añadimos FUERZAS
            //Transform.forward al eje Z DE POSTROTBALL               /
            rbBall.AddForce(transform.forward * _thrustZ);

            // Destruimos bola al rato
            Destroy(cloneBall, _timeBall);
        }
    }


}
