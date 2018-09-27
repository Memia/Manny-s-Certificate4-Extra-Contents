using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is in charge of receiving input from the user and interacting with PlayerController
public class PlayerInput : MonoBehaviour
{
    public PlayerController controller;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(camRay, out hit, 1000f))
            {
                controller.SetDestination(hit.point);
            }
        }
    }
}
