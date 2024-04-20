using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class JugarCartal2 : MonoBehaviour
{
    public GameObject Card;
    public bool Turn = false;
    public bool jugable = true;

    public GameObject PHand;
    public GameObject EHand;
    public GameObject PMelee;
   public GameObject PDistance;
    public GameObject PSiege; 
    public GameObject EMelee;
    public GameObject EDistance;
     public GameObject ESiege;
    public GameObject pCmelee;
    public GameObject pCdistance; 
    public GameObject pCsiege; 
    public GameObject eCmelee;
     public GameObject eCdistance;
     public GameObject eCsiege;
    public GameObject Bloqueo1, Bloqueo2;

  
    
    public int position = 0;
    private object selectedCard;

    public void Awake()
    {
        AssignGameObjects();
    }

    public void AssignGameObjects()
    {
        PMelee = GameObject.Find("PlayerMelee");
        PDistance = GameObject.Find("PlayerDistance");
        PSiege = GameObject.Find("PlayerSiege");
        EMelee = GameObject.Find("EnemyMelee");
        EDistance = GameObject.Find("EnemyDistance");
        ESiege = GameObject.Find("EnemySiege");
        pCmelee = GameObject.Find("pMeleeClimage");
        pCdistance = GameObject.Find("pDistanceClimage");
        pCsiege = GameObject.Find("pSiegeClimage");
        eCmelee = GameObject.Find("eMeleeClimage");
        eCdistance = GameObject.Find("eDistanceClimage");
        eCsiege = GameObject.Find("eSiegeClimage");
        PHand = GameObject.Find("PlayerHand");
        EHand = GameObject.Find("EnemyHand");
    }

    public void PlayCard()
{
    if (selectedCard != null)
    {
        Card = (GameObject)selectedCard;
        ClaseCarta carta = Card.GetComponent<ClaseCarta>();

        if (Turn && jugable && carta.Faction == "Dragons")
        {
            switch (carta.Frange)
            {
                case 1:
                    MoveCardToZone(PMelee);
                    break;
                case 2:
                    MoveCardToZone(PDistance);
                    break;
                case 3:
                    MoveCardToZone(PSiege);
                    break;
                case 4:
                    MoveCardToZone(pCmelee);
                    break;
                case 5:
                    MoveCardToZone(pCdistance);
                    break;
                case 6:
                    MoveCardToZone(pCsiege);
                    break;
                default:
                    break;
            }
        }
        else if (!Turn && jugable && carta.Faction == "Beasts")
        {
            switch (carta.Frange)
            {
                case 1:
                    MoveCardToZone(EMelee);
                    break;
                case 2:
                    MoveCardToZone(EDistance);
                    break;
                case 3:
                    MoveCardToZone(ESiege);
                    break;
                case 4:
                    MoveCardToZone(eCmelee);
                    break;
                case 5:
                    MoveCardToZone(eCdistance);
                    break;
                case 6:
                    MoveCardToZone(eCsiege);
                    break;
                default:
                    break;
            }
        }
        // Add more cases for other card types as needed
    }
    else
    {
        Debug.LogError("No card selected");
    }
}

    private void MoveCardToZone(GameObject eCsiege)
    {
        throw new NotImplementedException();
    }
}