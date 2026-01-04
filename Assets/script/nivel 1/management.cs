using UnityEngine;
using UnityEngine.SceneManagement;

public class management : MonoBehaviour
{
    //private int _vidasPlayer;
    //private int _vidasEnemigo;
    [SerializeField] private int _vacasEncerradas;
    private Rigidbody2D _rigidbody2;
    //[SerializeField] private int _torosEncerrados;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // _vidasEnemigo = 10;
        // _vidasPlayer = 10;
        _vacasEncerradas = 0;
        //_torosEncerrados = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (_vacasEncerradas==2)
        {
            SceneManager.LoadScene("tapa2");// carga la escena nivel 2
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) //suma una vaca al corral
    {
        if (collision.gameObject.CompareTag("vaca"))
        {
            _vacasEncerradas++;
        }
    }
    private void OnTriggerExit2D(Collider2D collision) // se escapo una vaca
    {
        if (collision.gameObject.CompareTag("vaca"))
        {
            _vacasEncerradas--;
        }
    }
}
