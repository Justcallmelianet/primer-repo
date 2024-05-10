using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseClima : MonoBehaviour
{
    private GameObject Cardentry;
    public List<GameObject> CardsinFrange; 
     public string Faction;
     public GameObject CementerioDragons;
     public GameObject CementerioBeasts;
     
    



    private void OnCollisionEnter2D(Collision2D collision) //cuando colisionan mete las cartas en la lista de la franja 
     {
        Cardentry = collision.gameObject; //designandoa la carta nueva en lalista como lo que sea que colisione
        CardsinFrange.Add(Cardentry); // meto la carta nueva en la lista 
     }
     
     
}
