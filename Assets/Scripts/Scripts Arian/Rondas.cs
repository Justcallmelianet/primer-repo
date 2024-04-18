using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rondas : MonoBehaviour
{
        private bool rondaActiva = false;
        private bool cartaJugada = false;

         public void IniciarRonda(){
            if (!rondaActiva)
        {
            rondaActiva = true;
            cartaJugada = false;
        }
        else
        {
            Debug.Log("Ya hay una ronda en progreso");
        }
    }

         


   public void JugarCarta()
    {
        if (rondaActiva && !cartaJugada)
        {
            Debug.Log("Carta jugada");
            cartaJugada = true;
        }
        else if (!rondaActiva)
        {
            Debug.Log("No hay ronda activa para jugar carta");
        }
        else
        {
            Debug.Log("Ya se jugó una carta en esta ronda");
        }
    }

          public void FinalizarRonda()
    {
        rondaActiva = false;
        cartaJugada = false;
    }
}

