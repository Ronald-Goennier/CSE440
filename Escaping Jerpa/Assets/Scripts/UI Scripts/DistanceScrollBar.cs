using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceScrollBar : MonoBehaviour
{
    private Slider slider;
    private float slideTimer;

	// Use this for initialization
	void Start ()
    {
        slider = gameObject.GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        slideTimer += Time.deltaTime;
        slider.value = slideTimer;
	}
}
