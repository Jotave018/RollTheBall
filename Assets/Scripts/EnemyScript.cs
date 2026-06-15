using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public Transform alvo;
    private NavMeshAgent navMeshAgent;
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        if (navMeshAgent == null)
        {
            Debug.LogError("EnemyScript precisa de um NavMeshAgent no mesmo GameObject.");
        }
    }
    void Update()
    {
        if (alvo != null)
        {
            navMeshAgent.SetDestination(alvo.position);
        }
    }
}
