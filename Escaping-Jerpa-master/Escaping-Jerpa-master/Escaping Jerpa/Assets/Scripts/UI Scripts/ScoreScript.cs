using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Controls how to keep score for the entire game
/// </summary>
public class ScoreScript : MonoBehaviour
{
    public int scoreKeeper;
    private Text m_Text;

    // Use this for initialization
    void Start()
    {
        m_Text = gameObject.GetComponentInChildren<Text>();
        if(!m_Text)
        {
            Debug.Log("Could not find text component");
        }
        scoreKeeper = 0;
        UpdateScore();
    }

    public void AddScore(int scorePoints)
    {
        scoreKeeper += scorePoints;
        if(scoreKeeper >= 100)
        {
            scoreKeeper += scorePoints;
        }
        UpdateScore();
    }

    private void Update()
    {
        UpdateScore();
    }

    private void UpdateScore()
    {
        m_Text.text = "Score: " + scoreKeeper.ToString();
    }
}