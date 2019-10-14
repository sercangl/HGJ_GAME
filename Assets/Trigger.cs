using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;
    private float movement=-2.0f;
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
            
            //  Debug.Log("BreakAnim is true");
            //movement = movement - 1.0f;
            
            Debug.Log(movement);
            // breakAnim = true;
        }
    }

    void Update()
    {
        //movement = Input.GetAxisRaw("Horizontal") * speed; //Yatay Eksende Hareket.

        //movement = -movement * Time.deltaTime;

        //speed = speed * Time.deltaTime ;
        //Debug.Log(speed);

    }

    void FixedUpdate()
    {
        //speed = speed * Time.deltaTime;
        movement = movement - 0.005f;
        Debug.Log(speed);
        rb.MovePosition(rb.position + new Vector3(movement * Time.fixedDeltaTime, 0f)); // Y eksenindeki hareket sıfır.

       // speed = speed * -12f;
       // Debug.Log("bastık");
    }

}
