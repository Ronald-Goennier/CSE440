using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

    [SerializeField]
    private Animator destroyanim;

    [SerializeField]
    private int health = 10;

    private int currentHealth;

    void Start()
    {      
        destroyanim.SetBool("isdestroy", false);
        currentHealth = health;
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        //destroy enemy if it collides with objects tagged "bulletcollide"
        if (coll.gameObject.tag == "bulletcollide")
        {
            currentHealth -= 5;
            if (currentHealth <= 0)
            {
                GetComponent<Collider2D>().enabled = false;
                destroyanim.SetBool("isdestroy", true);
                StartCoroutine(time());
            }
        }
    }

    IEnumerator time()
    {
        yield return new WaitForSeconds(.50f);
        Destroy(gameObject);

    }
    
}
