using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieVillain : MonoBehaviour
{
    private void OnCollisionEnter(Collision infoCollission)
    {

        if (infoCollission.gameObject.CompareTag("FlowerThrow"))
        {

            Destroy(gameObject);

        }
    }
}
