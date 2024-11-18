using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsMouse : MonoBehaviour
{

    private void OnMouseDown()
    {
        Debug.Log("Actúo cuando hago clic con el botón izquierdo del " +
                  "ratón sobre el objeto");
    }
    private void OnMouseUp()
    {
        Debug.Log("Actúo cuando dejo de hacer clic con el botón izquierdo del " +
                  "ratón sobre el objeto");
    }
    private void OnMouseOver()
    {
        Debug.Log("Actúo cuando estoy sobre el collider");
    }
    private void OnMouseExit()
    {
        Debug.Log("Actúo cuando dejo de estar sobre el collider");
    }
    private void OnMouseDrag()
    {
        Debug.Log("Actúo cuando arrastro el objeto");
    }
}
