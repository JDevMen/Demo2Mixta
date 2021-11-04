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
            timeRemaining -= Time.deltaTime;
        } else if(timeRemaining < 0 && isTriggering)
        {
            SaleDelBarrido();
        }
    }

    public void SaleDelBarrido()
    {
        Debug.Log("Entra a SaleDelBarrido");
        GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "SaleDelBarrido", ""));
    }

    public void CabezaArriba()
    {
        Debug.Log("Entra a CabezaArriba");
        // Si la cabeza sale por más de 10 segundos el man muere
        // GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "CabezaArriba", ""));
    }

    public void EncontrarSalida()
    {
        Debug.Log("Entra a EncontrarSalida");
        // Si la cabeza sale por más de 10 segundos el man muere
        GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "EncontrarSalida", ""));
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Esta onTrigger");
        GameObject obj = other.gameObject;

        if (obj.CompareTag("EspacioMuerto"))
        {
            Debug.Log("Es espacio muerto");
            //SaleDelBarrido();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Esta onTrigger");
        GameObject obj = other.gameObject;

        if (obj.CompareTag("EspacioMuerto"))
        {
            Debug.Log("Es espacio muerto");
            isTriggering = false;
            timeRemaining = 10;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entra a collisionar");
        GameObject obj = other.gameObject;

        if (obj.CompareTag("EspacioMuerto"))
        {
            Debug.Log("Es espacio muerto");
            //SaleDelBarrido();
            isTriggering = true;
        }
    }
}
