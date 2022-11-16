using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float speed = 5f;
    public float rotationspeed = 200f;
    public float X, Y;
    private Animator anim;
    public Rigidbody rb;
    public float JumpForce = 9.81f; 
    public bool CanJump;

    void Start()
    {
        anim = GetComponent<Animator>(); 
        CanJump = false;    
    }
    private void FixedUpdate()
    {
        transform.Rotate(0, X * Time.deltaTime * rotationspeed, 0);
        transform.Translate(0, 0, Y * Time.deltaTime * speed);
    }

    void Update()
    {   X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");

        anim.SetFloat("VelX", X);
        anim.SetFloat("VelY", Y);

        if (CanJump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("Jump", true);
                rb.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
            }
            anim.SetBool("TouchFloor", true);
        }
        else
        {
         ImFalling();
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
            Debug.Log(Input.GetKey(KeyCode.W));
        }
        if (Input.GetKey(KeyCode.S))
        {   
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {  
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {     
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
    public void ImFalling()
    {
        anim.SetBool("TouchFloor", false);
        anim.SetBool("Jump", false);
    }
}
