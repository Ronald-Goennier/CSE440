using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

    [SerializeField]
    private Animator destroyanim;
    public int scorePoints;

    private ScoreScript scoreController;

    [SerializeField]
    private int health = 10;

    private int currentHealth;

    void Start()
<<<<<<< HEAD
    {      
        destroyanim.SetBool("isdestroy", false);
        currentHealth = health;
=======
    {   
        destroyanim.SetBool("isdestroy", false);
        GameObject scoreControllerObject = GameObject.FindGameObjectWithTag("ScoreController");
        if(scoreControllerObject)
        {
            scoreController = scoreControllerObject.GetComponent<ScoreScript>();
        }
        if(!scoreControllerObject)
        {
            Debug.Log("No score script found");
        }
        
>>>>>>> 38fa50236a2736686a8fee59514654f598f350ed
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        //destroy enemy if it collides with objects tagged "bulletcollide"
        if (coll.gameObject.tag == "bulletcollide")
        {
<<<<<<< HEAD
            currentHealth -= 5;
            if (currentHealth <= 0)
            {
                GetComponent<Collider2D>().enabled = false;
                destroyanim.SetBool("isdestroy", true);
                StartCoroutine(time());
            }
=======
            scoreController.AddScore(scorePoints);
            GetComponent<Collider2D>().enabled = false;
            destroyanim.SetBool("isdestroy",true);
            StartCoroutine(time());
>>>>>>> 38fa50236a2736686a8fee59514654f598f350ed
        }
    }

    IEnumerator time()
    {
        yield return new WaitForSeconds(.50f);
        Destroy(gameObject);
    }
    
}
