using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghostwall : MonoBehaviour
{
    public GameObject stopper;
    public bool enter = false;
    

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
        
    }

     void OnTriggerEnter(Collider other)
    {
        Debug.Log("s");
        enter = true;
       
    }
    private void OnTriggerExit(Collider other)
    {
        enter = false;
    }
}
