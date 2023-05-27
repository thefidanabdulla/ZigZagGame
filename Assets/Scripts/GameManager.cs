using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GeneratePlatform generatePlatform;
    public bool gameOver;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GameStart()
    {
        UIManager.instance.GameStart();
    }
    public void GameOver() {
        SoundManager.instance.GameOver();
        generatePlatform.StopGeneratePlatforms();
        gameOver = true;
    }
    public void IncreaseScore()
    {
        ScoreManager.instance.IncreaseScore();
    }
}
