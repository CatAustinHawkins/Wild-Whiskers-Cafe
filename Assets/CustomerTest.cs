using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CustomerTest : MonoBehaviour
{
    public Transform target;

    NavMeshAgent agent;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    public void Update()
    {
        agent.SetDestination(target.position);
    }
}

