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
    private bool stunned;

    // Use this for initialization
    void Start()
    {
        healthSlider.value = maxHealth;
        currentHealth = maxHealth;
        stunned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            OnDeath();
        }

        if (stunned)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                GetComponent<PCmovement>().enabled = true;
                time = 3;
            }

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
        if (coll.gameObject.tag == "death" || coll.gameObject.tag == "obstacletag" || coll.gameObject.tag == "stun")
        {
            if (coll.gameObject.tag == "obstacletag")   //destroy player regardless of health if collision with obstacle
            {
                Destroy(gameObject);
            }
            else if (coll.gameObject.tag == "stun")
            {
                GetComponent<PCmovement>().enabled = false;
                stunned = true;
            }
            else
            {
                TakeDamage(5);
            }
        }
    }

    void OnDeath()
    {
        trail.transform.SetParent(null); //seperate trail from parent player object
        Destroy(gameObject); // destroy player

        SceneManager.LoadScene("MainMenu");
    }
}