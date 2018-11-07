using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//destroy player

public class DestroyPlayer : MonoBehaviour {

    public GameObject trail;
    public Slider healthSlider;
    public int maxHealth;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        //health = gameObject.GetComponent<Health>();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {      
        //destroy player if it collides with objects tagged as "death" or  "ostabletag"
        if (coll.gameObject.tag == "death" || coll.gameObject.tag == "obstacletag")
        {
            GameObject otherObject = coll.gameObject;
            //trail.transform.SetParent(null);
            TakeDamage(5);
            Destroy(otherObject);
            //Destroy(gameObject);
        }
    }
    void TakeDamage(int dmg)
    {
        currentHealth -= dmg;
        healthSlider.value = currentHealth;
    }

}
