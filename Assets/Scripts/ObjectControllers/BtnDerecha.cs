using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnDerecha : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Touched()
    {
        Debug.Log("Entra");
        GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "Touched", ""));
        gameObject.SetActive(false);
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
