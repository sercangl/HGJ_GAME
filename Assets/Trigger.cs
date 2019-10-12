using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    private float movement=0;
    private ParticleSystem WallBreakParticle;
    public bool moduleEnabled;

    public bool enter = false;
    public bool stay = true;
    public bool exit = true;
    public bool breakAnim = false;
    
    void Start()
    {
        WallBreakParticle = GetComponent<ParticleSystem>();
    }
    
    void ButtonPressHandler()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("BreakAnim is true");
            // breakAnim = true;
        }
    }

    void Update()
    {
    movement = Input.GetAxisRaw("Horizontal") * speed; //Yatay Eksende Hareket.

       
        

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector3(movement * Time.fixedDeltaTime, 0f)); // Y eksenindeki hareket sıfır.
    }

}
