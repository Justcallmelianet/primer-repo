using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Card> cards;

    public void ApplyEffect(int effectNumber)
    {
        switch (effectNumber)
        {
            case 1:
                AumentoEnFilaPropia();
                break;
            case 2:
                PonerClima();
                break;
            case 3:
                EliminarCartaMasPoder();
                break;
            case 4:
                EliminarCartaMenosPoderRival();
                break;
            case 5:
                RobarCarta();
                break;
            case 6:
                MultiplicarAtaquePorCantidad();
                break;
            case 7:
                LimpiarFilaMenosUnidades();
                break;
            case 8:
                IgualarPoderPromedio();
                break;
            default:
                break;
        }
    }

    // Implementa cada uno de estos métodos según la lógica y estructura de tu juego
    private void AumentoEnFilaPropia()
    {
        // Implementa la lógica aquí
    }

    private void PonerClima()
    {
        // Implementa la lógica aquí
    }

    private void EliminarCartaMasPoder()
    {
        // Implementa la lógica aquí
    }

    private void EliminarCartaMenosPoderRival()
    {
        // Implementa la lógica aquí
    }

    private void RobarCarta()
    {
        // Implementa la lógica aquí
    }

    private void MultiplicarAtaquePorCantidad()
    {
        // Implementa la lógica aquí
    }

    private void LimpiarFilaMenosUnidades()
    {
        // Implementa la lógica aquí
    }

    private void IgualarPoderPromedio()
    {
        // Implementa la lógica aquí
    }
}

public class Carta
{
    public int Points { get; set; }
    public string Type { get; set; }
    // Otras propiedades y métodos de la carta
}

public class Row
{
    public List<Card> Cards { get; set; }

    public void IncreasePointsInRow(int additionalPoints)
    {
        foreach (var card in Cards)
        {
            card.Points += additionalPoints;
        }
    }
}

public class Game
{
    public List<Card> Deck { get; set; }
    public List<Card> EnemyBattlefield { get; set; }

    public void PlayWeatherCardThroughCard(Card card)
    {
        if (card.Type== "Weather")
        {
            // Aquí puedes implementar la lógica para jugar la carta de clima
            // Por ejemplo, puedes agregarla a un campo de batalla
            Debug.Log("Carta de clima jugada!");
        }
        else
        {
            // Busca una carta de clima en el mazo
            Card weatherCard = Deck.Find(c => c.Type == "Weather");
            if (weatherCard != null)
            {
                // Aquí puedes implementar la lógica para jugar la carta de clima
                // Por ejemplo, puedes agregarla a un campo de batalla
                Debug.Log("Carta de clima jugada a través de otra carta!");
            }
            else
            {
                Debug.Log("No hay cartas de clima en el mazo.");
            }
        }
    }

    public void RemoveEnemyCardWithMostPoints()
    {
        if (EnemyBattlefield.Count > 0)
        {
            // Encuentra la carta con más puntos
            Card cardWithMostPoints = EnemyBattlefield.OrderByDescending(card => card.Points).First();

            // Elimina la carta del campo de batalla del enemigo
            EnemyBattlefield.Remove(cardWithMostPoints);

            Debug.Log("La carta con más puntos ha sido eliminada del campo de batalla del enemigo.");
        }
        else
        {
            Debug.Log("El campo de batalla del enemigo está vacío.");
        }
    }
}
