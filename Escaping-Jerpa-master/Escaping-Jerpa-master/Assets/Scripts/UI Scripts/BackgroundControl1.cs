using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControl1 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float timer;

	// Use this for initialization
	void Start ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            spriteRenderer.enabled = true;
        }
		
	}
}
