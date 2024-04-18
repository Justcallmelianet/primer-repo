using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClaseCarta : MonoBehaviour
    {
   
    public string Name; //nombre de la carta
    private int OriginalPower;  //campo para guardar el poder original de la carta, no se cambia para saber el poder de la carta y devolverlo al original cuando utilicen un despeje
    public int Power;  //campo para guardar el indice de poder que veran los jugadores y es el que va a cambiar con los efectos y el clima
    public string DescriptionEffects; // campo para guardar la descripcion y explicar el efecto de la carta en caso de que tenga
    public string Faction; //campo para guardar la faccion
    public string Type; //campo para guardar si es de oro o plata
    public int Frange; // campo para guardar la franja en la que se juega la carta
    public bool Affected = false ; //campo para saber si la carta esta siendo afectada por un clima
    public bool Repartir = false; // cod para arreglar el problema del mazo a la hora de repartir cartas 
    public bool Sumar = false;// para saber si ya esta sumada en la franja

    
    }

   

