using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_Text highScoreText;
    private void Start()
    {  
            int highScore = PlayerPrefs.GetInt(ScoreSystem.HighScoreKey, 0);
            highScoreText.text = $"High Score: {highScore}";
    }


    public void ClickPlay()
    {

    SceneManager.LoadScene(1); 
    }
}
