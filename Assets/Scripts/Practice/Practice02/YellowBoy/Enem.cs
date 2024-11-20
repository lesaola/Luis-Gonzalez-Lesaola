using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enem : MonoBehaviour
{
    private void OnTriggerEnter(Collider infoAccess)
    {

        if (infoAccess.CompareTag("AttackSword"))
        {
        
            Destroy(gameObject);
        
        }

    }
}
