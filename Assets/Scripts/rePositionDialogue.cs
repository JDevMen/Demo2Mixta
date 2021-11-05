using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rePositionDialogue : MonoBehaviour
{
    private GameObject playerHead;

    private Transform transf;

    // Start is called before the first frame update
    void Start()
    {
        playerHead = GameObject.FindGameObjectWithTag("MainCamera");
        transf = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transf.position = playerHead.transform.position;   
    }
}
