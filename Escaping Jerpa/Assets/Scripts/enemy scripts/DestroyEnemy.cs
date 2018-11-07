using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyEnemy : MonoBehaviour
{
    
    public int scorePoints;
    private ScoreScript scoreController;
    

    private void Start()
    {
        GameObject scoreControllerObject = GameObject.FindWithTag("GameController");
        if(scoreControllerObject)
        {
            scoreController = scoreControllerObject.GetComponent<ScoreScript>();
        }
        else if(!scoreControllerObject)
        {
            Debug.Log("Cannot find score script");
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        //destroy enemy if it collides with objects tagged "bulletcollide"
        if (coll.gameObject.tag == "bulletcollide" & gameObject.tag != "obstacletag")
        {
            
            if (scorePoints > 0)
            {
                scoreController.AddScore(scorePoints);
            }
            Destroy(gameObject);
        }
    }

}
