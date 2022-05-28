using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControllerNavMesh : MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent agent;
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }
}
