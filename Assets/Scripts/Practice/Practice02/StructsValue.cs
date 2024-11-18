using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class StructsValue : MonoBehaviour
{

    // Variables Globales
    public Color MyColor = new Color(0.99f, 0.644f, 0.0f, 0.5f);
    public Color32 MyTrueColor = new Color(255, 165, 0, 0.5f);
    public Vector2 MyVector2 = new Vector2(1.5f, 2.5f);
    public Vector3 MyVector3 = new Vector3(1.5f, 2.5f, 3.5f);
    public Quaternion MyQuaternion = Quaternion.identity;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
