using UnityEngine;
using System;

public class Eventos : MonoBehaviour
{
    public static event Action eventobala1;
    public float timer;
    public float instantiateTime;

    void Start()
    {
        
    }

   
    void Update()
    {
        timer -= 1 * Time.deltaTime;
        if (timer <= 0)
        {
            GameObject bala = PuntaCanon.Instance.Cagada();
            bala.transform.position = transform.position + Vector3.right * Time.deltaTime;
            timer = instantiateTime;
        }

    }
}
