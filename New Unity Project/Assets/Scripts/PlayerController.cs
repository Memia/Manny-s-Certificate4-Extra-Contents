using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//This script handles player movement and rotation logic
public class PlayerController : MonoBehaviour
{
    public NavMeshAgent agent;
    private Vector3 targetPos;
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        if (targetPos.magnitude >0)
        {
            agent.SetDestination(targetPos);
        }
    }
    public void SetTarget(Vector3 target)
    {
        targetPos = target;
    }
}
