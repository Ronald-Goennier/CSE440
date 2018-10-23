using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletMovement : MonoBehaviour
{

    [SerializeField]
    private float speed;
    [SerializeField]
    private float destroyBulletTime;
   

    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {

        transform.Rotate(new Vector3(0, 0, 180));
        rb.velocity = transform.right * speed;

        Destroy(gameObject, destroyBulletTime);
    }

    void Update()
    {
        //Physics2D.IgnoreLayerCollision(1, 10, false);
        Physics2D.IgnoreLayerCollision(10, 10);
        //Physics2D.IgnoreLayerCollision(13, 10);
    }



    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.layer == 1 || coll.gameObject.layer == 8)
        {
            Destroy(gameObject);
        }
    }



}
