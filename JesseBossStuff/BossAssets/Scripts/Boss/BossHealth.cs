using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{

    //[SerializeField]
    //private Animator destroyanim;

    [SerializeField]
    private GameObject ChildRotation;

    [SerializeField]
    private int health = 100;

    private int currentHealth;

    //public Slider  BossHealthSlider;

    void Start()
    {
        //destroyanim.SetBool("isdestroy", false);
        currentHealth = health;

        //BossHealthSlider = GetComponent < Slider> ();
        //BossHealthSlider.value = health;
    }

    /*public int Health
    {
        get { return health; }
        set
        {
            health -= value;
            if (currentHealth >= 75)
            {
                GetComponent<BossBulletSingle>().enabled = true;

                if (currentHealth <= 75 && currentHealth >= 50)
                {
                    GetComponent<BossBulletSingle>().enabled = false;

                    GetComponent<BossMovement>().enabled = true;
                    GetComponent<BossSpreadShooting>().enabled = true;

                    if (currentHealth <= 50 && currentHealth >= 25)
                    {

                        if (currentHealth <= 25 && currentHealth >= 0)
                        {


                        }
                    }
                }

            }
        }
    }*/

    void OnCollisionEnter2D(Collision2D coll)
    {
        //destroy enemy if it collides with objects tagged "bulletcollide"
        if (coll.gameObject.tag == "bulletcollide")
        {
            currentHealth -= 5;

            //BossHealthSlider.value = currentHealth;

            if (currentHealth <= 0)
            {
                GetComponent<Collider2D>().enabled = false;
                //destroyanim.SetBool("isdestroy", true);
                StartCoroutine(time());
            }
        }
        if (currentHealth >= 75)
        {
            GetComponent<BossBulletSingle>().enabled = true;
        }

        if (currentHealth <= 75 && currentHealth >= 50)
        {
            GetComponent<BossBulletSingle>().enabled = false;

            GetComponent<BossMovement>().enabled = true;
            GetComponent<BossSpreadShooting>().enabled = true;
        }

        if (currentHealth <= 50 && currentHealth >= 25)
        {
            GetComponent<BossSpreadShooting>().enabled = false;
            transform.rotation = Quaternion.Euler(0, 0, 90);

            GetComponent<BossBulletSingle>().enabled = true;
            GetComponent<BossStunShot>().enabled = true;
            GetComponent<BossWaveFire>().enabled = true;
        }

        if (currentHealth <= 25 && currentHealth >= 0)
        {
            GetComponent<BossStunShot>().enabled = true;
            GetComponent<BossWaveFire>().enabled = true;
            GetComponent<BossMovement>().enabled = true;
            GetComponent<BossSpreadShooting>().enabled = true;
        }
    }

        IEnumerator time()
    {
        yield return new WaitForSeconds(.50f);
        Destroy(gameObject);
    }
}