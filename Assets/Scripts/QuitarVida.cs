using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarVida : MonoBehaviour
{
    public float damage = 1.0f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Vidas>() != null)
        {
            other.gameObject.GetComponent<Vidas>().QuitarVida(damage);

        }
    }
}
