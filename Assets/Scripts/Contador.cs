using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour

{
    // Crear una lista para cada franja
    public List<GameObject> franjaMeleePlayer = new List<GameObject>();
    public List<GameObject> franjaAsedioPlayer = new List<GameObject>();
    public List<GameObject> franjaDistanciaPlayer = new List<GameObject>();

    public List<GameObject> franjaMeleeEnemigo = new List<GameObject>();
    public List<GameObject> franjaAsedioEnemigo = new List<GameObject>();
    public List<GameObject> franjaDistanciaEnemigo = new List<GameObject>();

    // Contadores para cada franja
    private int totalMeleePlayer = 0;
    private int totalAsedioPlayer = 0;
    private int totalDistanciaPlayer = 0;

    private int totalMeleeEnemigo = 0;
    private int totalAsedioEnemigo = 0;
    private int totalDistanciaEnemigo = 0;

    // Contador total
    private int totalPlayer = 0;
    private int totalEnemigo = 0;

    void Start()
    {
        // Añadir cartas a las franjas (esto es solo un ejemplo, puedes añadir tus propias cartas)
        franjaMeleePlayer.Add(new GameObject("Carta 1"));
        franjaAsedioPlayer.Add(new GameObject("Carta 2"));
        franjaDistanciaPlayer.Add(new GameObject("Carta 3"));

        franjaMeleeEnemigo.Add(new GameObject("Carta 4"));
        franjaAsedioEnemigo.Add(new GameObject("Carta 5"));
        franjaDistanciaEnemigo.Add(new GameObject("Carta 6"));

        // Sumar los puntos de cada carta en las franjas
        totalMeleePlayer = franjaMeleePlayer.Count;
        totalAsedioPlayer = franjaAsedioPlayer.Count;
        totalDistanciaPlayer = franjaDistanciaPlayer.Count;

        totalMeleeEnemigo = franjaMeleeEnemigo.Count;
        totalAsedioEnemigo = franjaAsedioEnemigo.Count;
        totalDistanciaEnemigo = franjaDistanciaEnemigo.Count;

        // Sumar los puntos totales
        totalPlayer = totalMeleePlayer + totalAsedioPlayer + totalDistanciaPlayer;
        totalEnemigo = totalMeleeEnemigo + totalAsedioEnemigo + totalDistanciaEnemigo;

        // Imprimir los resultados
        Debug.Log("Total puntos jugador: " + totalPlayer);
        Debug.Log("Total puntos enemigo: " + totalEnemigo);

        if (totalPlayer > totalEnemigo)
        {
            Debug.Log("El jugador gana la ronda");
        }
        else if (totalEnemigo > totalPlayer)
        {
            Debug.Log("El enemigo gana la ronda");
        }
        else
        {
            Debug.Log("La ronda termina en empate");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
