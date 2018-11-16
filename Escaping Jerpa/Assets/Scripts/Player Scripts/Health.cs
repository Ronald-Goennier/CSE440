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
    [SerializeField]
    private float time;
<<<<<<< HEAD
    private bool stunned;
=======

    private bool stunned;
    private GameOverScript gameOver;
>>>>>>> 38fa50236a2736686a8fee59514654f598f350ed

<<<<<<< HEAD

	// Use this for initialization
	void Start ()
=======
    // Use this for initialization
    void Start()
>>>>>>> c7a625dfaf804a5defced6bd84fb017a6381768a
    {
        healthSlider.value = maxHealth;
        currentHealth = maxHealth;
        stunned = false;
<<<<<<< HEAD
    }

    // Update is called once per frame
    void Update()
=======

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
>>>>>>> 38fa50236a2736686a8fee59514654f598f350ed
    {
        if (currentHealth <= 0)
        {
            OnDeath();
        }

        if (stunned)
        {
            Stunned();
        }
    }

    void TakeDamage(int dmg)
    {
        currentHealth -= dmg;
        healthSlider.value = currentHealth;
    }

    void GiveHealth(int health)
    {
        currentHealth += health;
        healthSlider.value = currentHealth;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //check collision for objects that collide with player
<<<<<<< HEAD
        if (coll.gameObject.tag == "death" || coll.gameObject.tag == "obstacletag" || coll.gameObject.tag == "stun")
=======
        if (coll.gameObject.tag == "death" || coll.gameObject.tag == "obstacletag" || coll.gameObject.tag == "damage" || coll.gameObject.tag == "stun")
>>>>>>> 38fa50236a2736686a8fee59514654f598f350ed
        {
            if (coll.gameObject.tag == "obstacletag")   //destroy player regardless of health if collision with obstacle
            {
                currentHealth = 0;
                //Destroy(gameObject);
            }
<<<<<<< HEAD
            else if (coll.gameObject.tag == "stun")
            {
                GetComponent<PCmovement>().enabled = false;
                stunned = true;
            }
            else
            {
                TakeDamage(5);
            }
=======
            else if (coll.gameObject.tag == "death")
            {
                TakeDamage(coll.gameObject.GetComponent<BulletDamage>().Damage);
            }
            else if(coll.gameObject.tag == "damage")
            {
                TakeDamage(5);
            }
            else if (coll.gameObject.tag == "stun")
            {
                GetComponent<PCmovement>().enabled = false;
                stunned = true;
            }
        }

        //collision check for medkits
        if (coll.gameObject.tag == "medkit")
        {
            Destroy(coll.gameObject);
            GiveHealth(5);
>>>>>>> 38fa50236a2736686a8fee59514654f598f350ed
        }
    }

    void OnDeath()
    {
        trail.transform.SetParent(null); //seperate trail from parent player object
        gameOver.b_isDead();
        Destroy(gameObject); // destroy player
        
        
        //SceneManager.LoadScene("MainMenu");
    }
<<<<<<< HEAD

    void Stunned()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            GetComponent<PCmovement>().enabled = true;
            time = 3;
        }
    }
}
=======
}
>>>>>>> c7a625dfaf804a5defced6bd84fb017a6381768a
