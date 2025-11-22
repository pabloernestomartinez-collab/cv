using UnityEngine;
using UnityEngine.AI;

public class enemigo : MonoBehaviour
{
   
    [SerializeField] private Transform _objetive;
    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        _agent.SetDestination(_objetive.transform.position);
    }

}
