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

    private GameOverScript gameOver;

	// Use this for initialization
	void Start ()
    {
        healthSlider.value = maxHealth;
        currentHealth = maxHealth;

        GameObject gameOverObject = GameObject.FindGameObjectWithTag("GameOverMenu");
        if(gameOverObject)
        {
            gameOver = gameOverObject.GetComponent<GameOverScript>();
        }
        if(!gameOverObject)
        {
            Debug.Log("No game over found");
        }
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
        if (coll.gameObject.tag == "death" || coll.gameObject.tag == "obstacletag" || coll.gameObject.tag == "damage")
        {
            if (coll.gameObject.tag == "obstacletag")   //destroy player regardless of health if collision with obstacle
            {
                currentHealth = 0;
                //Destroy(gameObject);
            }
            else if (coll.gameObject.tag == "death")
            {
                TakeDamage(coll.gameObject.GetComponent<BulletDamage>().Damage);
            }
            else if(coll.gameObject.tag == "damage")
            {
                TakeDamage(5);
            }
        }
    }

    void OnDeath()
    {
        trail.transform.SetParent(null); //seperate trail from parent player object
        gameOver.b_isDead();
        Destroy(gameObject); // destroy player
        
        
        //SceneManager.LoadScene("MainMenu");
    }
}
