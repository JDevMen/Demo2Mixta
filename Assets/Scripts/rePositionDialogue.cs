using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rePositionDialogue : MonoBehaviour
{
    private GameObject playerHead;

    private Transform transf;

    public float distance_head = 3f;

    // Start is called before the first frame update
    void Start()
    {
        playerHead = GameObject.FindGameObjectWithTag("MainCamera");
        transf = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offsetDialog = (transf.position + Vector3.Normalize(playerHead.transform.rotation.eulerAngles))*distance_head;

        transf.position = offsetDialog;
    }
}
