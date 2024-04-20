using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTurn : MonoBehaviour
{
    public int Ronda = 1;
    public bool Turno = true;
    public ClaseMano PlayerHand;
    public ClaseMano EnemyHand;
    public GameObject Bloqueo1;
    public GameObject Bloqueo2;
    private int gutts = 1;
    private int griffith = 1;
    private int Mano1 = 0;
    private int Mano2 = 0;
    private int comparator1 = 0;
    private int comparator2 = 0;
    private RectTransform bloqueo1;
    private RectTransform bloqueo2;



    void Start()
    {
        bloqueo1 = Bloqueo1.GetComponent<RectTransform>();
        bloqueo2 = Bloqueo2.GetComponent<RectTransform>();
    }

    void Update()
    {
    
        if(PlayerHand.JuegoCarta())
        {
            Turno = false;
        }

        if(EnemyHand.JuegoCarta())
        {
            Turno = true;
        }
    }
}

public class ClaseMano
{
    public int Cartas { get; internal set; }

    internal bool JuegoCarta()
    {
        throw new NotImplementedException();
    }

    internal bool JugoCarta()
    {
        throw new NotImplementedException();
    }
}