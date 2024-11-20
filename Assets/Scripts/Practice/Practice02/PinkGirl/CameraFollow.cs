using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    // Variables globales

    public Transform Target;
    // velocidad de seguimiento de la camara hacia el target
    private float _smoothing;
    // distancia inicial entre el Target y la camara
    private Vector3 _offset;

    

    void Start()
    {
        // offset = posicion de camara - posicion de target. Es el vector que los une
        _offset = transform.position - Target.position;
        _smoothing = 1.5f;

    }

    
    void Update()
    {

        //posicion a la que quiero mover la camara
        Vector3 camPosition = Target.position + _offset;
        transform.position = Vector3.Lerp(transform.position, camPosition, _smoothing * Time.deltaTime);

    }
}
