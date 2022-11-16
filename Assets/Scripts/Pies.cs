using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pies : MonoBehaviour
{
    public Jugador logicaPersonaje1;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
   private void OnTriggerStay(Collider other)
    {
        logicaPersonaje1.CanJump = true;
    }
   private void OnTriggerExit(Collider other)
    {
        logicaPersonaje1.CanJump = false;
    }

}
