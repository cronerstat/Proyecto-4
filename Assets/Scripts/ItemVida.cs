using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemVida : MonoBehaviour
{
    public float vida = 1.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Vidas>() != null)
        {
            other.gameObject.GetComponent<Vidas>().DarVida(vida);

        }
    }
}