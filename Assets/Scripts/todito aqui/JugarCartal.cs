using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JugarCartal : MonoBehaviour
{
    public GameObject Card;
    public bool Turn = false;
    public bool jugable = true;

    public GameObject PHand, EHand, PMelee, PDistance, PSiege, EMelee, EDistance, ESiege;
    public GameObject pCmelee, pCdistance, pCsiege, eCmelee, eCdistance, eCsiege;
    public GameObject Bloqueo1, Bloqueo2;
    private List<GameObject> mazo;
    private List<GameObject> mazoenemigo;
    private int position;

    private void Start()
    {
        AssignGameObjects();
    }

    private void AssignGameObjects()
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
        ClaseCarta carta = Card.GetComponent<ClaseCarta>();

        if (jugable && ((Turn && carta.Faction == "Dragons") || (!Turn && carta.Faction == "Beasts")))
        {
            switch (carta.Frange)
            {
                case 1:
                    MoveCardToZone(Turn ? PMelee : EMelee);
                    break;
                case 2:
                    MoveCardToZone(Turn ? PDistance : EDistance);
                    break;
                case 3:
                    MoveCardToZone(Turn ? PSiege : ESiege);
                    break;
                case 4:
                    MoveCardToZone(Turn ? pCmelee : eCmelee);
                    break;
                case 5:
                    MoveCardToZone(Turn ? pCdistance : eCdistance);
                    break;
                case 6:
                    MoveCardToZone(Turn ? pCsiege : eCsiege);
                    break;
                // Add more cases for other card types as needed
                default:
                    break;
            }
        }
    }

    private void MoveCardToZone(GameObject zone)
    {
        Card.transform.SetParent(zone.transform, false);
        Card.transform.position = zone.transform.position;
        jugable = false;
    }

    public void VerificarCarta(bool isPlayer)
    {
        List<GameObject> currentMazo = isPlayer ? mazo : mazoenemigo;
        int count = isPlayer ? 2 : 0;

        for (int i = 0; i < count; i++)
        {
            position = Random.Range(0, currentMazo.Count);
            if (!currentMazo[position].GetComponent<ClaseCarta>().Repartir)
            {
                GameObject card = Instantiate(currentMazo[position], Vector2.zero, Quaternion.identity);
                card.transform.SetParent(isPlayer ? PHand.transform : EHand.transform, false);
                currentMazo[position].GetComponent<ClaseCarta>().Repartir = true;
            }
            else
            {
                i--; // Retry if the card is already distributed
            }
        }
    }

    public void NlunarGutts()
    {
        if (mazo.Count > 2)
        {
            VerificarCarta(true);
        }
    }

    public void NLunarGriffith()
    {
        if (mazoenemigo.Count > 2)
        {
            VerificarCarta(false);
        }
    }

    private void Update()
    {
        mazo = GameObject.Find("PlayerDeck").GetComponent<PDrawCards>().mazo;
        mazoenemigo = GameObject.Find("EnemyDeck").GetComponent<eDrawCards>().mazo;
    }
}