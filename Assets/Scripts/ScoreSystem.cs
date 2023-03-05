using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public const string HighScoreKey="HighScore";

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplier;
    float score = 0f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        score +=scoreMultiplier*Time.deltaTime;
        scoreText.text=Mathf.FloorToInt(score).ToString();

        
    }
    private void OnDestroy()
    {
        int currentHighScore=PlayerPrefs.GetInt(HighScoreKey, 0);
        if (currentHighScore < score )
        {
            PlayerPrefs.SetInt(HighScoreKey, Mathf.FloorToInt(score));
        }
    }
}
