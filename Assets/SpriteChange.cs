using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour {

    [SerializeField]
    private Sprite[] civCarSprites;

    private int chooseSprite;

	// Use this for initialization
	void Start () {
        chooseSprite = Random.Range(1, 10);
        GetComponent<SpriteRenderer>().color = new Color(.4f, .4f, .4f, .9f);
        if (chooseSprite == 5)
            transform.localScale = new Vector3(1f, 1f, 1f);
        else transform.localScale = new Vector3(.5f, .5f, .5f);
    }

    void Update()
    {
        if (chooseSprite < 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = civCarSprites[0];
        }
        else if (chooseSprite > 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = civCarSprites[1];
        }
        else if (chooseSprite == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = civCarSprites[2];
        }

    }

}
