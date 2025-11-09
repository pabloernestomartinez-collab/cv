using UnityEngine;

public class MovimientoVaca : MonoBehaviour
{
    private Rigidbody2D _rb; // referencia al componente Rigidbody2D de la vaca
    private float _speed; // velocidad de la vaca
    public Animator animator; // su nombre lo dice
    private float _direccionX; // direccion en X
    private float _direccionY; // direccion en Y

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); // obtener el componente Rigidbody2D del objeto
        _speed = 0.5f;
        _direccionX = Random.Range(-1f,1f);
        _direccionY = Random.Range(-1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (_rb.position.x > 8f) // limitar el movimiento en X
        {
            _rb.position = new Vector2(8f, _rb.position.y);
            _direccionX = -1f;
        }

        if (_rb.position.x < -8f)
        {
            _rb.position = new Vector2(-8f, _rb.position.y);
            _direccionX = 1f;
        }

        if (_rb.position.y > 4f) // limitar el movimiento en Y
        {
            _rb.position = new Vector2(_rb.position.x, 4f);
            _direccionY = -1f;
        }

        if (_rb.position.y < -5f)
        {
            _rb.position = new Vector2(_rb.position.x, -5f);
            _direccionY = 1f;
        }

        _rb.position = new Vector2(_rb.position.x + _direccionX * _speed * Time.deltaTime, _rb.position.y + _direccionY * _speed * Time.deltaTime);

        animator.SetFloat("direccionX", _direccionX);
        animator.SetFloat("direccionY", _direccionY);

        Debug.Log(_direccionX);


        if (_direccionX < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);//invierte el sprite dependiendo de hacia donde se dirija
        }
        else if (_direccionX > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);// invierte el sprite dependiendo de hacia donde se dirija
        }

    }

}
