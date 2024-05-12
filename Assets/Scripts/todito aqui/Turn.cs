using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Scripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class Turn : MonoBehaviour
{
    public bool isYourTurn;
    public int PlayerTurn;
    public int EnemyTurn;
    public Text Turntext;
    public int maxmana;
    public int currentmana;
    public bool canPlay;
    public bool hasPlayedCard; // nueva variable para rastrear si se ha jugado una carta
 
    void Start()
    {
        isYourTurn = true;
        PlayerTurn = 1;
        EnemyTurn = 0;
        maxmana = 1;
        currentmana = 1;
        canPlay = true;
        hasPlayedCard = false; // inicializar en false
    }

    void Update()
    {
        if (isYourTurn == true)
        {
            if (canPlay && !hasPlayedCard) // solo puede jugar si no ha jugado una carta
            {
                // Aquí es donde se juega la carta
                hasPlayedCard = true; // establecer en true después de jugar una carta
                canPlay = false;
            }
        }
        else
        {
            if (canPlay && !hasPlayedCard) // solo puede jugar si no ha jugado una carta
            {
                // Aquí es donde se juega la carta
                hasPlayedCard = true; // establecer en true después de jugar una carta
                canPlay = false;
            }
        }
    }

    public void EndPlayerTurn()
    {
        isYourTurn = false;
        EnemyTurn += 1;
        currentmana = maxmana;
        canPlay = true; // permitir que el enemigo juegue una carta
        hasPlayedCard = false; // restablecer a false al final del turno
    }

    public void EndEnemyTurn()
    {
        isYourTurn = true;
        PlayerTurn += 1;
        currentmana = maxmana;
        canPlay = true; // permitir que el jugador juegue una carta
        hasPlayedCard = false; // restablecer a false al final del turno
    } 
}