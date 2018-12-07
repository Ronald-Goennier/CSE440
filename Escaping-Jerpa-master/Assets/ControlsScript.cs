using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsScript : MonoBehaviour
{
    public Button back;
    public GameObject mainMenu;
	// Use this for initialization
	void Awake ()
    {
        Button btn = back.GetComponent<Button>();
        btn.onClick.AddListener(Back);

        //gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Circle"))
        {
            Back();
        }
    }

    void Back()
    {
        mainMenu.SetActive(true);
        gameObject.SetActive(false);
    }
}
