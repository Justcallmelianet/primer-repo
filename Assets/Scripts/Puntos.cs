using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
     public Text kiuraText;

    public GameObject pCC;
    public GameObject pD;
    public GameObject pS;
   public GameObject suma;
    private int sumakiura = 0;

    void Update()
    {
        int semisuma = 0;
        semisuma = pCC.GetComponent<ClaseFranja>().Suma + pD.GetComponent<ClaseFranja>().Suma + pS.GetComponent<ClaseFranja>().Suma;
        sumakiura = semisuma;
        kiuraText.text = sumakiura.ToString();
    }
}
