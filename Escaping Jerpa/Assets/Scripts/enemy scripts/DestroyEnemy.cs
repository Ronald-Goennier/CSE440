using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyEnemy : MonoBehaviour
{
    
    public int scorePoints;
    private ScoreScript scoreController;

    [SerializeField]
    private Animator destroyanim;

    private void Start()
    {
        GameObject scoreControllerObject = GameObject.FindWithTag("GameController");
        if (scoreControllerObject)
        {
            scoreController = scoreControllerObject.GetComponent<ScoreScript>();
        }
        else if (!scoreControllerObject)
        {
            Debug.Log("Cannot find score script");
        }

        destroyanim.SetBool("isdestroy", false);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //destroy enemy if it collides with objects tagged "bulletcollide"
        if (coll.gameObject.tag == "bulletcollide")
        {

            
            if (scorePoints > 0)
            {
                scoreController.AddScore(scorePoints);
            }
            GetComponent<Collider2D>().enabled = false;
            destroyanim.SetBool("isdestroy",true);
            StartCoroutine(time());
        }
    }

    IEnumerator time()
    {
        yield return new WaitForSeconds(.50f);
        Destroy(gameObject);

    }
    
}
