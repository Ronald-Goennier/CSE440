using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Slider healthSlider;
    public int maxHealth;
    private int currentHealth;
    public GameObject trail;

	// Use this for initialization
	void Start ()
    {
        healthSlider.value = maxHealth;
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(currentHealth <= 0)
        {
            OnDeath();
        }
	}

    void TakeDamage(int dmg)
    {
        currentHealth -= dmg;
        healthSlider.value = currentHealth;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //check collision for objects that collide with player
        if (coll.gameObject.tag == "death" || coll.gameObject.tag == "obstacletag")
        {
            if (coll.gameObject.tag == "obstacletag")   //destroy player regardless of health if collision with obstacle
            {
                Destroy(gameObject);
            }
            else
                TakeDamage(5);
        }
    }

    void OnDeath()
    {
        trail.transform.SetParent(null); //seperate trail from parent player object
        Destroy(gameObject); // destroy player

        SceneManager.LoadScene("MainMenu");
    }
}
