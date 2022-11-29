using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float balaSpeed = 5f;
    [SerializeField] private Rigidbody balaRb;  

    private void OnEnable()
    {
        balaRb.velocity = Vector3.right * balaSpeed;
    }

    private void OnCollisionEnter()
    {
        gameObject.SetActive(false);    
    }
}
