using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollText : MonoBehaviour
{
    [SerializeField]
    private float timer;

    [SerializeField]
    private float speed;

    private bool isMoving = true;
	// Update is called once per frame
	void Update ()
    {
        if (isMoving)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                isMoving = false;
            }
            MoveText(Vector2.up);
        }
	}

    void MoveText(Vector2 direction)
    {
        gameObject.transform.Translate(direction * speed * Time.deltaTime);
    }
}
