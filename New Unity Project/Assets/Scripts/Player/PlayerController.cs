using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//This script handles player movement and rotation logic
public class PlayerController : MonoBehaviour
{
    public NavMeshAgent agent;

    public void SetDestination(Vector3 target)
    {
        //Create a new instance of path to contain new path
        NavMeshPath path = new NavMeshPath();
        //Calculate the new path to target
        if (agent.CalculatePath(target, path))
        {
            //If the path generated is completed (not partial)
            if (path.status == NavMeshPathStatus.PathComplete)
            {
                //Tell the agent to go to target
                agent.SetDestination(target);
            }
        }
    }
}
