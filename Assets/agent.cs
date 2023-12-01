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
        if (navMeshAgent.velocity.magnitude > 0.1f)
        {
            if (navMeshAgent.velocity.x > 0)
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
            else if (navMeshAgent.velocity.x < 0)
            {
                transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }
    }
}
