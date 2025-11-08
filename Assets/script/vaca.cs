using UnityEngine;
using UnityEngine.InputSystem;

public class vaca : MonoBehaviour
{
    private Rigidbody2D _rb; // referencia al componente Rigidbody2D de la vaca
    private float _speed; // velocidad de la vaca
    public Animator animator; // su nombre lo dice
    private Vector2 move; 
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
        _rb.position = new Vector2(_rb.position.x + _direccionX * _speed * Time.deltaTime, _rb.position.y + _direccionY * _speed * Time.deltaTime);

        if (_rb.position.x > 8.1f) // limitar el movimiento en X
        {
            _rb.position = new Vector2(8f, _rb.position.y);
            _direccionX = -_direccionX;
        }

        if (_rb.position.x < -8f)
        {
            _rb.position = new Vector2(-8f, _rb.position.y);
            _direccionX = -_direccionX;
        }

        if (_rb.position.y > 4f) // limitar el movimiento en Y
        {
            _rb.position = new Vector2(_rb.position.x, 4f);
            _direccionY = -_direccionY;
        }

        if (_rb.position.y < -4.5f)
        {
            _rb.position = new Vector2(_rb.position.x, -4.5f);
            _direccionY = -_direccionY;
        }

        animator.SetFloat("moveX", move.x);
        animator.SetFloat("moveY", move.y);

        if (move.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);//invierte el sprite dependiendo de hacia donde se dirija
        }
        else if (move.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);// invierte el sprite dependiendo de hacia donde se dirija
        }

    }

}
