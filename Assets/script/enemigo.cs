using UnityEngine;
using UnityEngine.AI;

public class enemigo : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private Transform _objetive;
    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;
        _rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        _agent.SetDestination(_objetive.transform.position);
    }
    private void OnCollisionEnter2D(Collision2D collision)//ataca el enemigo
    {
        if (collision.gameObject.CompareTag("Player"))//    tag == "Player" mata al player
        {
            Destroy(collision.gameObject); // destruir el objeto que colisiona con el misil
        }
        else if (collision.gameObject.CompareTag("Toro"))//    tag == "toro" se suicida
        {
            //Destroy(gameObject);
            
        }
    }
    
}
