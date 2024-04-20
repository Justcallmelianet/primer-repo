using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiuraEffect : MonoBehaviour
{
       private bool miLiderActivo = false;

        public void ActivarKiura()
    {
        if (!miLiderActivo)
        {
            Debug.Log("!Gane yo PERRA sufre y soporta!");
            miLiderActivo = true;
        }
    }
}
