using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectTecho : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("techoHumo"))
        {
            Debug.Log("Está tocando el techo");
        }
            
    }
}
