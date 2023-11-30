using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agent : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;


    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        navMeshAgent.updateRotation = false;
        navMeshAgent.updateUpAxis = false;
        transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }

    void Update()
    {
        
    }
}
