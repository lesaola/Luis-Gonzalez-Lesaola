using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentsGet : MonoBehaviour
{

    //Variables globales
    private Light _myLight;
    public BoxCollider BoxColliderCube;


    private void Awake()
    {
        // Inicializacion del componente "Light" (mi "gameObject" tiene el componente Light)
        _myLight = GetComponent<Light>();
        BoxColliderCube.enabled = false;
    }



    // Start is called before the first frame update
    void Start()
    {
        
        _myLight.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
