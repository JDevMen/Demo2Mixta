using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usuario : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Está collisionando");
        GameObject EspacioMuerto = collision.gameObject;

        if (EspacioMuerto.CompareTag("EspacioMuerto"))
        {
            Debug.Log("Es espacio muerto");
            //SaleDelBarrido();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Sale de colisionar");
        GameObject EspacioMuerto = collision.gameObject;

        if (EspacioMuerto.CompareTag("EspacioMuerto"))
        {
            Debug.Log("Es espacio muerto");
            //SaleDelBarrido();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entra a collisionar");
        GameObject EspacioMuerto = collision.gameObject;

        if(EspacioMuerto.CompareTag("EspacioMuerto"))
        {
            Debug.Log("Es espacio muerto");
            //SaleDelBarrido();
        }
    }
}
