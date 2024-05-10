using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardInSD : MonoBehaviour
{
    public GameObject Card;
    public Text InfoText;
    private GameObject DescriptionText;
    private Text Information;

    void Start()
    {
        DescriptionText = GameObject.Find("DescriptionText");
    }
    
    public void MouseEnter()
    {
        InfoText.text = Card.GetComponent<ClaseCarta>().Name + " PODER: " + Card.GetComponent<ClaseCarta>().Power.ToString() + " TIPO: " + Card.GetComponent<ClaseCarta>(). Type + " FRANJA: " + Card.GetComponent<ClaseCarta>().TipoFranja + " FACCIÓN: " + Card.GetComponent<ClaseCarta>().Faction;
        Information = Instantiate(InfoText, new Vector2(0,0), Quaternion.identity);
        Information.transform.SetParent(DescriptionText.transform, false);
    }


    public void MouseExit()
    {
       Destroy(Information.gameObject);
    }
}


