using TMPro;
using UnityEngine;

public class canvas : MonoBehaviour
{
    public TextMeshProUGUI cartel; // referente al componente TMPGui para mostrar la vida 1

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cartel.text = "Cantidad de vacas recuperadas: 2 de 8 Cantidad de toros recuperados:5 de 10 distancia al enemigo: 37 m"; // Imprime los datos de la pantalla actual
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
