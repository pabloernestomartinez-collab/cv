using UnityEngine;
using UnityEngine.InputSystem;

public class palyer : MonoBehaviour
{
    private Rigidbody2D _rb; // referencia al componente Rigidbody2D del jugador
    private float _delay = 0.5f; // delay entre disparos
    public float speed; // velocidad del palyer

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); // obtener el componente Rigidbody2D del objeto
        speed = 700f;
    }
    private void OnMove(InputValue inputValue)
    {
        Vector2 move = inputValue.Get<Vector2>(); // obtener el valor del input

        _rb.linearVelocity = move * speed * Time.deltaTime; //permanente;// mantiene el movimiento del jugador
    }

    // Update is called once per frame
    void Update()
    {
        if (_rb.position.x > 8f) // limitar el movimiento en X
        {
            _rb.position = new Vector2(8f, _rb.position.y);
        }
        if (_rb.position.x < -8f)
        {
            _rb.position = new Vector2(-8f, _rb.position.y);
        }
        if (_rb.position.y > 4.5f) // limitar el movimiento en Y
        {
            _rb.position = new Vector2(_rb.position.x, 4.5f);
        }
        if (_rb.position.y < -4.5f)
        {
            _rb.position = new Vector2(_rb.position.x, -4.5f);
        }
        _delay += Time.deltaTime; // incrementar el delay
    }
   
}
