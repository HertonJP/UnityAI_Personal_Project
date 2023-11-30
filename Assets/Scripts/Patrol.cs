using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class Patrol : Action
{
    [SerializeField] private Transform[] patrolPoints;
    [SerializeField] private float speed = 5f;
    private int currentPatrolIndex = 0;

    public override TaskStatus OnUpdate()
    {
        if (patrolPoints.Length == 0)
        {
            return TaskStatus.Failure;
        }

        transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPatrolIndex].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, patrolPoints[currentPatrolIndex].position) < 0.1f)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
        }

        return TaskStatus.Running;
    }
}
