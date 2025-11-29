using UnityEngine;
using UnityEngine.AI;

public class perro : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private Transform _objetive;
    [SerializeField] private Transform _cucha;
    private Transform _cambio;

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
    private void OnCollisionEnter2D(Collision2D collision) //ataca el enemigo
    {
        if (collision.gameObject.CompareTag("Toro"))//    tag == "toro" mata al perro
        {
            _cambio = _objetive;
            _objetive = _cucha;
            _cucha = _cambio;
        }
    }

}