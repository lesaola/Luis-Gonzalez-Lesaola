using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsMouse : MonoBehaviour
{

    private void OnMouseDown()
    {
        Debug.Log("Act�o cuando hago clic con el bot�n izquierdo del " +
                  "rat�n sobre el objeto");
    }
    private void OnMouseUp()
    {
        Debug.Log("Act�o cuando dejo de hacer clic con el bot�n izquierdo del " +
                  "rat�n sobre el objeto");
    }
    private void OnMouseOver()
    {
        Debug.Log("Act�o cuando estoy sobre el collider");
    }
    private void OnMouseExit()
    {
        Debug.Log("Act�o cuando dejo de estar sobre el collider");
    }
    private void OnMouseDrag()
    {
        Debug.Log("Act�o cuando arrastro el objeto");
    }
}
