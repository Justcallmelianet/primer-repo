using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class eDrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;
    public GameObject Card5;
    public GameObject Card6;
    public GameObject Card7;
    public GameObject Card8;
    public GameObject Card9;
    public GameObject Card10;
    public GameObject Card11;
    public GameObject Card12;
    public GameObject Card13;
    public GameObject Card14;
    public GameObject Card15;
    public GameObject Card16;
    public GameObject Card17;
    public GameObject Card18;
    public GameObject Card19;
    public GameObject Card20;
    public GameObject Card21;
    public GameObject Card22;
    public GameObject Card23;
    public GameObject Card24;
    public GameObject Card25;
    public GameObject Card26;
    public GameObject Card27;
    public GameObject Card28;
    public GameObject Card29;
    public GameObject Card30;
    

    public GameObject Hand;
    public GameObject PlayerHand;
    public List<GameObject> mazo = new List<GameObject>(); // Lista de prefabs de cartas en el mazo
    public List<GameObject> hand = new List<GameObject>(); // Lista de prefabs de cartas en la mano
    public List<GameObject> cartasJugadas= new List<GameObject>();
    internal bool robo;
    internal bool robo2;

    public void Clicked()
{
    // Referencia al objeto "Mano" en el juego

    for(int i = 0; i < 10; i++)
    {
        if(mazo.Count > 0)
        {
            int cartaIndex = Random.Range(0, mazo.Count);
            GameObject cartaPrefab = mazo[cartaIndex];

            GameObject carta = Instantiate(cartaPrefab,new Vector2(0,0), Quaternion.identity);
            carta.transform.SetParent(Hand.transform, false); // Establecer el objeto carta como hijo de "Mano"
            hand.Add(cartaPrefab);

            mazo.RemoveAt(cartaIndex);
        }
        else
        {
            Debug.Log("El mazo está vacío.");
        }
    }


}





    // Start is called before the first frame update
    void Start()
    {
        
        mazo.Add(Card1);
        mazo.Add(Card2);
        mazo.Add(Card3);
        mazo.Add(Card4);
        mazo.Add(Card5);
        mazo.Add(Card6);
        mazo.Add(Card7);
        mazo.Add(Card8);
        mazo.Add(Card9);
        mazo.Add(Card10);
        mazo.Add(Card11);
        mazo.Add(Card12);
        mazo.Add(Card13);
        mazo.Add(Card14);
        mazo.Add(Card15);
        mazo.Add(Card16);
        mazo.Add(Card17);
        mazo.Add(Card18);
        mazo.Add(Card19);
        mazo.Add(Card20);
        mazo.Add(Card21);
        mazo.Add(Card22);
        mazo.Add(Card23);
        mazo.Add(Card24);
        mazo.Add(Card25);
        mazo.Add(Card26);
        mazo.Add(Card27);
        mazo.Add(Card28);
        mazo.Add(Card29);
        mazo.Add(Card30);
       
        JugarRonda(1, 10);
        JugarRonda(2, 3);
        JugarRonda(3, 4);
        JugarRonda(4, 5);
    

        // Shuffle(Mazo); //las barajeo desde el principio
    
    }

   void JugarRonda(int ronda, int cantidad)
    {
        Debug.Log("Ronda " + ronda);

        for (int i = 0; i < cantidad; i++)
        {
            if (mazo.Count == 0)
            {
                Debug.Log("No hay más cartas en el mazo");
                break;
            }

            int cartaIndex = Random.Range(0, mazo.Count); // Asegurarse de que el índice esté dentro del rango
            GameObject cartaJugada = mazo[cartaIndex]; // Obtener la carta

            cartasJugadas.Add(cartaJugada); // Agregar la carta jugada a la lista de cartas jugadas
            mazo.RemoveAt(cartaIndex); // Eliminar la carta jugada del mazo

            Debug.Log("Carta jugada: " + cartaJugada.name);
        }
    }

    internal void MoverACarta(Vector3 position)
    {
        throw new System.NotImplementedException();
    }
}
    

     


    
    