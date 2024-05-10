using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ClaseFranja : MonoBehaviour
{
    public List<GameObject> CardsinFrange;

    public Text puntuationText;
    public string Faction;
    public int franja;
    public GameObject CementerioDragons;
    public GameObject CementerioBeasts;
    public GameObject PlayerHand;
    public GameObject EnemyHand;

    public int Suma { get; internal set; }

    void Update()
    {
        
    }

}