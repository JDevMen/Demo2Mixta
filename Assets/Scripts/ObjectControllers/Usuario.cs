using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usuario : MonoBehaviour
{

    private float timeRemaining = 10;
    private bool isTriggering = false;
    private float offset = 1f;
    private bool hasFinished = false;
    public void endCoords()
    {
        Vector3 vectorCamera = GameObject.Find("Main Camera").transform.position;
        Vector3 vectorCameraAdj = new Vector3(vectorCamera.x, 0, vectorCamera.z);

        Vector3 vectorSalidaIzquierda = GameObject.Find("BtnSalidaIzquierda").transform.position;
        Vector3 vectorSalidaIzquierdaAdj = new Vector3(vectorSalidaIzquierda.x, 0, vectorSalidaIzquierda.z);
        Debug.Log("Distancia: " + Vector3.Distance(vectorSalidaIzquierdaAdj, vectorCameraAdj));
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasFinished && timeRemaining > 0 && isTriggering)
        {
            Debug.Log(timeRemaining);
            timeRemaining -= Time.deltaTime;
        }
        else if (!hasFinished && timeRemaining < 0 && isTriggering)
        {
            SaleDelBarrido();
            hasFinished = true;
            GameObject.FindGameObjectWithTag("Dialogue").SetActive(true);
            
        }
        EncontrarSalida();
    }

    public void SaleDelBarrido()
    {
            Debug.Log("Entra a SaleDelBarrido asi que perdiste");
            GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "SaleDelBarrido", ""));
    }

    public void CabezaArriba()
    {
        Debug.Log("Entra a CabezaArriba");
        // Si la cabeza sale por m?s de 10 segundos el man muere
        // GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "CabezaArriba", ""));
    }

    public void EncontrarSalida()
    {
        Vector3 vectorCamera = GameObject.Find("Main Camera").transform.position;
        Vector3 vectorCameraAdj = new Vector3(vectorCamera.x, 0, vectorCamera.z);

        Vector3 vectorSalidaIzquierda = GameObject.Find("BtnSalidaIzquierda").transform.position;
        Vector3 vectorSalidaIzquierdaAdj = new Vector3(vectorSalidaIzquierda.x, 0, vectorSalidaIzquierda.z);
        if (!hasFinished && Vector3.Distance(vectorCameraAdj, vectorSalidaIzquierdaAdj) <= offset)
        {
            hasFinished = true;
            GameObject.FindGameObjectWithTag("Dialogue").SetActive(true);
            Debug.Log("Ganamos!");
            GameObject.Find("SimulationController").GetComponent<SimulationController>().VerifyUserAction(new SimulationObject.Action(gameObject.name, "EncontrarSalida", ""));
        }

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