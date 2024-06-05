using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameM : MonoBehaviour
{
    public static GameM instance;
    private int m_score = 0;
    private TMPro.TextMeshProUGUI Text;  
    private void Awake() {
        if (instance == null)
            instance = this;
    }

    private void Start() => Text = GameObject.Find("Canvas/ScoreText").GetComponent<TMPro.TextMeshProUGUI>();

    public void AddScore(int score)
    {
        m_score += score;
        Text.text = "Score: " + m_score.ToString();
    }
}
