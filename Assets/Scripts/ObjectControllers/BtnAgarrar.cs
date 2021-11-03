using System;
using System.Collections;
using UnityEngine;

public class BtnAgarrar: MonoBehaviour
{
    private Animator animator;

    // Control de activación 
    public bool pTouched = false;

    void Start()
    {
        pTouched = false;
    }

    public void ElementosAgarrados()
    {
        Debug.Log("Entra");
        GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "ElementosAgarrados",""));
    }

    public void ElementosNoAgarrados()
    {
        GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "ElementosNoAgarrados",""));
    }

    /** Este método sirve para detectar que se oprime el botón en VR
    /*  Puede usarse con la mano virtual, en este caso se usa un collider en el dedo índice, 
    /*  para detectar la colisión entre el botón y el dedo
    **/
    IEnumerator OnTriggerEnter(Collider other)
    {
        if (!pTouched && other.tag =="IndexFinger")
        {
            pTouched = true;
            ElementosAgarrados();
            yield return new WaitForSeconds(0.5f);    
            pTouched = false;    
        }
    }

    IEnumerator OnMouseDown()
    {
        if (!pTouched)
        {
            pTouched = true;
            ElementosAgarrados();
            yield return new WaitForSeconds(0.5f);    
            pTouched = false;    
        }
    }
}
