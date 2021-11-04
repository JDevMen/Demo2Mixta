using System;
using System.Collections;
using UnityEngine;

public class BtnAgarrar : MonoBehaviour
{

    public void ElementosAgarrados()
    {
        Debug.Log("Entra");
        GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "ElementosAgarrados", ""));
        gameObject.SetActive(false);
    }

    public void ElementosNoAgarrados()
    {
        GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "ElementosNoAgarrados", ""));
    }

    /** Este m�todo sirve para detectar que se oprime el bot�n en VR
    /*  Puede usarse con la mano virtual, en este caso se usa un collider en el dedo �ndice, 
    /*  para detectar la colisi�n entre el bot�n y el dedo
    **/
    // IEnumerator OnTriggerEnter(Collider other)
    // {
    //     if (!pTouched && other.tag == "IndexFinger")
    //     {
    //         pTouched = true;
    //         ElementosAgarrados();
    //         yield return new WaitForSeconds(0.5f);
    //         pTouched = false;
    //     }
    // }

    // IEnumerator OnMouseDown()
    // {
    //     if (!pTouched)
    //     {
    //         pTouched = true;
    //         ElementosAgarrados();
    //         yield return new WaitForSeconds(0.5f);
    //         pTouched = false;
    //     }
    // }
}
