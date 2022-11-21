using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public float maxVidas = 10.0f;
    public float actualVida;
    public GameObject Reiniciar;
    public Image GameOver;

    void Start()
    {
        actualVida = maxVidas;
        GameOver.enabled = false;
        Reiniciar.gameObject.SetActive(false);
    }

    void Update()
    {
        if (actualVida > maxVidas)
        {
            actualVida = maxVidas;
        }
        if (actualVida <= 0)
        {
            Muerte();
        }
    }

    public void QuitarVida(float damage)
    {
        actualVida -= damage;
    }
    public void DarVida(float vida)
    {
        actualVida += vida;
    }
    public void Muerte()
    {
        Destroy(this.gameObject);
        Reiniciar.gameObject.SetActive(true);
        GameOver.enabled = true;
    }
}

