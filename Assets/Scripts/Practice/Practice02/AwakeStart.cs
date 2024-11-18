using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeStart : MonoBehaviour
{

    private void Awake()
    {

        Debug.Log("Soy el Awake y me ejecuto en primer lugar " + Time.deltaTime);

    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Soy el Start y me ejecuto en segundo lugar " + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Soy el Update y me ejecuto en CUARTO lugar " + Time.deltaTime);
    }


    private void FixedUpdate()
    {
        Debug.Log("Soy el FIXEDUpdate y me ejecuto en TERCER lugar " + Time.deltaTime);
    }



}
