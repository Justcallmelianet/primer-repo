using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rondas : MonoBehaviour
{
        private bool rondaEmpezada = false;
        private bool cartaJugada = false;

         public void IniciarRonda(){
            if (!rondaEmpezada)
        {
            rondaEmpezada = true;
            cartaJugada = false;
        }
        else
        {
            Debug.Log("Ya hay una ronda en progreso");
        }
    }

         


   public void JugarCarta()
    {
        if (rondaEmpezada && !cartaJugada)
        {
            Debug.Log("Carta jugada");
            cartaJugada = true;
        }
        else if (!rondaEmpezada)
        {
            Debug.Log("No hay ronda activa para jugar carta");
        }
        else
        {
            Debug.Log("Ya se jugó una carta en esta ronda");
        }
    }

          public void TerminarRonda()
    {
        rondaEmpezada = false;
        cartaJugada = false;
    }
}

