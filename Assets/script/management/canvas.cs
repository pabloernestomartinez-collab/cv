using TMPro;
using UnityEngine;

public class canvas : MonoBehaviour
{
    public TextMeshProUGUI cartel; // referente al componente TMPGui para mostrar la vida 1
    private string _texto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _texto = "renglon 1: hola mundo\nrenglon 2: chau pá"; // borrar cuando funcione*************
    }

    // Update is called once per frame
    void Update()
    {
        cartel.text = _texto; // Imprime los datos de la pantalla actual

    }
}
