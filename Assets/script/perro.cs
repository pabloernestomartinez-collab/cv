using UnityEngine;
using UnityEngine.AI;

public class perro : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _cucha;
    private Transform _objetivo;
    private NavMeshAgent _agent;


    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;
        _rb = GetComponent<Rigidbody>();
        _objetivo = _cucha;

    }

    // Update is called once per frame
    void Update()
    {
        _agent.SetDestination(_objetivo.transform.position);
    }
    private void OnCollisionEnter2D(Collision2D collision) //ataca el enemigo
    {
        if (collision.gameObject.CompareTag("Toro"))//    tag == "toro" envia a la cucha al perro
        {
            _objetivo = _cucha; // el perro se dirije a la cucha
        }
        if (collision.gameObject.CompareTag("Player"))//    tag == "player" llama al perro
        {
            _objetivo = _player; // el perro se dirije a la cucha
        }
    }

}