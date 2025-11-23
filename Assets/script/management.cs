using UnityEngine;

public class management : MonoBehaviour
{
    private int _vidasPlayer;
    private int _vidasEnemigo;
    private int _vacasEncerradas;
    private int _torosEncerrados;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _vidasEnemigo = 10;
        _vidasPlayer = 10;
        _vacasEncerradas = 0;
        _torosEncerrados = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
