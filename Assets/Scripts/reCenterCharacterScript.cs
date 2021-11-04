using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reCenterCharacterScript : MonoBehaviour
{
    CharacterController controller;

    GameObject camara;

    float x;

    float z;

    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();

        camara = GameObject.Find("Main Camera");

    }

    // Update is called once per frame
    void Update()
    {
        changeCenterPos();

    }

    private void changeCenterPos()
    {

        Vector3 position = camara.transform.position;

        x = position.x;

        z = position.z;

        float y = controller.center.y;

        Vector3 newPos = new Vector3(x, y, z);

        controller.center = newPos;
    }
}
