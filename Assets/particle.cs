using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Hit Wall");
            //Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("HitGhostwall");
        }




    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
