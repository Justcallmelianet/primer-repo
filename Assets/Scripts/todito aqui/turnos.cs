using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turnos : MonoBehaviour
{
   public bool PlayerTurn;
   public int PTurn;
   public int ETurn;
   
   void Start()
    {
      PlayerTurn=true;
      PTurn=1;
      ETurn=0;  
    }

    void Update()
    {
        
    }
      
      


    public void EndPlayerTurn(){
        PlayerTurn=false;
        ETurn+=1;
    }

    public void EndEnemyTurn(){
        PlayerTurn=true;
        PTurn+=1;
    }

}