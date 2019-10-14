using UnityEngine;
using UnityEngine.UI;



public class ScoreScript : MonoBehaviour
{
    public GameObject scoreText;
    private int theScore;
    public bool collision=false;
    void Start()
    {
       theScore = 0; 
    }

    void Update()
    {
        
        scoreText.GetComponent<Text>().text = "Score:" + theScore.ToString();

        /* if (collision)
         {
            theScore = theScore + 10;
             scoreText.GetComponent<Text>().text = "Score:" + theScore.ToString();
             collision = false;
         }
         */
    }
    void FixedUpdate()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        
        
        if (other.gameObject.CompareTag("Wall"))
        {
            //collision = true;
            theScore += 10;
           
        }      
    }
    //void OnTriggerExit(Collider other)
    //{
      //  collision = false;
    //}

}
