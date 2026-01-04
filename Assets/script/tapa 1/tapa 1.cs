using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class tapa1 : MonoBehaviour
{
    private Rigidbody2D _rb; // referencia al componente Rigidbody2D del jugador
    private float _speed; // velocidad del palyer
    public Animator animator;
    private Vector2 move;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); // obtener el componente Rigidbody2D del objeto
        _speed = 4f;
    }
    private void OnMove(InputValue inputValue)// verifica si se mueve new input system
    {
        move = inputValue.Get<Vector2>(); // obtener el valor del input
        _rb.linearVelocity = move * _speed; //permanente;// mantiene el movimiento del jugador
    }

    private void OnAttack() // salta el player cuando presiono ENTER (usar cuando estoy acorralado
    {
        SceneManager.LoadScene("nivel1");// carga la escena nivel 2
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

        transform.localScale = new Vector3(-1, 1, 1);
        if (move.x < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

    }

}
