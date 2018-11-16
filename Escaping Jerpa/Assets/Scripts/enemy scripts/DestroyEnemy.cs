using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

    [SerializeField]
    private Animator destroyanim;
    public int scorePoints;

    private ScoreScript scoreController;
    private GameObject scoreControllerObject;

    void Start()
    {   
        destroyanim.SetBool("isdestroy", false);
        scoreControllerObject = GameObject.FindGameObjectWithTag("ScoreController");
        if(scoreControllerObject)
        {
            scoreController = scoreControllerObject.GetComponent<ScoreScript>();
        }
        if(!scoreControllerObject)
        {
            Debug.Log("No score script found");
        }
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        //destroy enemy if it collides with objects tagged "bulletcollide"
        if (coll.gameObject.tag == "bulletcollide")
        {
            if (scoreControllerObject)
            {
                scoreController.AddScore(scorePoints);
            }
            GetComponent<Collider2D>().enabled = false;
            if (destroyanim)
            {
                destroyanim.SetBool("isdestroy", true);

            }
            StartCoroutine(time());
        }
    }

    IEnumerator time()
    {
        yield return new WaitForSeconds(.50f);
        Destroy(gameObject);
    }
    
}
