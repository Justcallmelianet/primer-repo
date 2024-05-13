using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTurn : MonoBehaviour
{
    public Button EndTurnPlayer;
    public Button EndTurnEnemy;
    public List<Card> PlayerDeck;
    public List<Card> EnemyDeck;
    public int PlayerCardsPlayed;
    public int EnemyCardsPlayed;
    public int currentRound = 1;
    public int PlayerTurnCount = 0;
    public int EnemyTurnCount = 0;

    void Start()
    {
        EndTurnPlayer.onClick.AddListener(PlayerEndTurn);
        EndTurnEnemy.onClick.AddListener(EnemyEndTurn);
    
    }



    void PlayerEndTurn()
    {
        if (PlayerDeck.Count > 0 && PlayerCardsPlayed < 1)
        {
            PlayCard(PlayerDeck);
            PlayerCardsPlayed++;
            PlayerTurnCount++;
            CheckEndRound();
        }
    }

    void EnemyEndTurn()
    {
        if (EnemyDeck.Count > 0 && EnemyCardsPlayed < 1)
        {
            PlayCard(EnemyDeck);
            EnemyCardsPlayed++;
            EnemyTurnCount++;
            CheckEndRound();
        }
    }

    
private void PlayCard(List<Card> enemyDeck)
    {
        throw new NotImplementedException();
    }

    void CheckEndRound()
    {
        if (PlayerDeck.Count == 0 && EnemyDeck.Count == 0)
        {
            currentRound++;
            if (currentRound <= 4)
            {
                // Reiniciar para la siguiente ronda
                ResetRound();
            }
            else
            {
                // El juego ha terminado después de 3 rondas
                EndGame();
            }
        }
    }

    void ResetRound()
    {
        PlayerCardsPlayed = 0;
        EnemyCardsPlayed = 0;
        PlayerTurnCount = 0;
        EnemyTurnCount = 0;
        
        // Añade aquí cualquier otra lógica de reinicio que necesites
    }

    void EndGame()
    {
        // Añade aquí la lógica para terminar el juego, como calcular puntuaciones y mostrar el ganador
    }
}

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    // Añade aquí las propiedades de tus cartas
    public int Points { get; internal set; }
    public string Type { get; internal set; }
}