using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text score;
    public Text lastScore;
    public Text highscore;
    



    private void Start()
    {
        highscore.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0).ToString();
        
    }

    public void ScorePoints()
    {
        int scorePoint = Trigger.counter;
        score.text = scorePoint.ToString();
        lastScore.text = "Last Score: " + scorePoint.ToString();
    
        

        if(scorePoint > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", scorePoint);
            highscore.text = "Highscore: " +  scorePoint;  
        }


    }
    private void Update()
    {
        ScorePoints();
    }
}
