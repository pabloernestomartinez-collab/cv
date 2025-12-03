using UnityEngine;

public class toro : MonoBehaviour
{
    private Rigidbody2D _rb; // referencia al componente Rigidbody2D del jugador
    private Vector2 movepermanente; // vector para mantener el movimiento constante del jugador
    private float _posicionX;
    private float _posicionY;
    private float _direccionX;
    private float _direccionY;
    private float _velocidad;


    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); // obtener el componente Rigidbody2D del objeto
        _posicionX = _rb.position.x;//posicion inicial
        _posicionY = _rb.position.y;
        _direccionX = 1 * Random.Range(-1f, 1f);//direccion inicial
        _direccionY = 1 * Random.Range(-1f, 1f);
        _velocidad = (1 - Mathf.Abs(_direccionX)) * 4f + (1 - Mathf.Abs(_direccionY)) * 4f;
    }

    // Update is called once per frame
    void Update()
    {
        _posicionX = _direccionX * _velocidad;//nueva posicion
        _posicionY = _direccionY * _velocidad;
        movepermanente = new Vector2(_posicionX, _posicionY);

        _rb.linearVelocity = movepermanente;// mantiene el movimiento de la vaca

        // limitar el movimiento en X
        if (_rb.position.x > 8f)
        {
            _direccionX = 1 * Random.Range(-1f, 0f);
            _direccionY = 1 * Random.Range(-1f, 1f);
            _velocidad = (1 - Mathf.Abs(_direccionX)) * 4f + (1 - Mathf.Abs(_direccionY)) * 4f;
        }
        if (_rb.position.x < -8f)
        {
            _direccionX = 1 * Random.Range(0f, 1f);
            _direccionY = 1 * Random.Range(-1f, 1f);
            _velocidad = (1 - Mathf.Abs(_direccionX)) * 4f + (1 - Mathf.Abs(_direccionY)) * 4f;
        }

        // limitar el movimiento en Y
        if (_rb.position.y > 4f)
        {
            _direccionX = 1 * Random.Range(-1f, 1f);
            _direccionY = 1 * Random.Range(-1f, 0f);
            _velocidad = (1 - Mathf.Abs(_direccionX)) * 4f + (1 - Mathf.Abs(_direccionY)) * 4f;
        }
        if (_rb.position.y < -4f)
        {
            _direccionX = 1 * Random.Range(-1f, 1f);
            _direccionY = 1 * Random.Range(0f, 1f);
            _velocidad = (1 - Mathf.Abs(_direccionX)) * 4f + (1 - Mathf.Abs(_direccionY)) * 4f;
        }

        //corrige la direccion del sprite
        if (_direccionX > 0f)
        {
            _rb.transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (_direccionX < 0f)
        {
            _rb.transform.localScale = new Vector3(1, 1, 1);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)//se te ataca el toro
    {
        if (collision.gameObject.CompareTag("Player"))//    tag == "Player")
        {
            _direccionX = (-_rb.transform.position.x + collision.gameObject.transform.position.x) * 2f;
            _direccionY = (-_rb.transform.position.y + collision.gameObject.transform.position.y) * 2f;
        }
    }

}

