using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCementery : MonoBehaviour
{
    
    public int cardCount = 0;

    public void AddCardToCementerio(GameObject card)
    {
        cardCount++;
        card.SetActive(false); // Desactivar la carta y agregarla al cementerio
        Debug.Log("Se ha agregado una carta al cementerio. Total: " + cardCount);
    }
    
    }




