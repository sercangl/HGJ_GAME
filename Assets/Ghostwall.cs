using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Ghostwall : MonoBehaviour
{
    public GameObject stopper;
    public bool enter = false;
    //public float coolDownTime=1f;
   // public float nextSpaceTime = 0f;
   



    void Start()
    {

        
    }


    void ButtonHandler()
    {
        if (enter)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
               
                    stopper.GetComponent<Collider>().isTrigger = false;
                    Debug.Log("space basıldı");
                    stopper.SetActive(false);
                
            }
          
        }
    }
    // Update is called once per frame
    void Update()
    {
        ButtonHandler();
      /*  if (Time.time > nextSpaceTime)
        {
            if (Input.GetKeyDown(KeyCode.Space)) {
                nextSpaceTime = Time.time + coolDownTime;
            }
        }
        else { ButtonHandler(); }
        */
    }

     void OnTriggerEnter(Collider other)
    {
        
       
        enter = true;

        
    }
    private void OnTriggerExit(Collider other)
    {
        enter = false;
    }
}
