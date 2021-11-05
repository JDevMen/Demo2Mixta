using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usuario : MonoBehaviour
{

    private float timeRemaining = 10;
    private bool isTriggering = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0 && isTriggering)
        {
            Debug.Log(timeRemaining);
            timeRemaining -= Time.deltaTime;
        }
        else if (timeRemaining < 0 && isTriggering)
        {
            SaleDelBarrido();
        }
    }

    public void SaleDelBarrido()
    {
        Debug.Log("Entra a SaleDelBarrido asi que perdiste");
        GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "SaleDelBarrido", ""));
    }

    public void CabezaArriba()
    {
        Debug.Log("Entra a CabezaArriba");
        // Si la cabeza sale por m�s de 10 segundos el man muere
        // GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "CabezaArriba", ""));
    }

    public void EncontrarSalida()
    {
        Debug.Log("Entra a EncontrarSalida");
        // Si la cabeza sale por m�s de 10 segundos el man muere
        GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "EncontrarSalida", ""));
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject obj = other.gameObject;

        if (obj.CompareTag("EspacioMuerto"))
        {
            if (isTriggering) isTriggering = false;
            timeRemaining = 10;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;

        if (obj.CompareTag("EspacioMuerto"))
        {
            //SaleDelBarrido();
            isTriggering = true;
        }

    }
}