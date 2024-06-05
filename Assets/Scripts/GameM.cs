using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameM : MonoBehaviour
{
    public static GameM instance;
    private int m_score = 0;
    private TMPro.TextMeshProUGUI Text;  
    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Canvas/ScoreText").GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int score)
    {
        m_score += score;
        Text.text = "Score: " + m_score.ToString();
    }
}
