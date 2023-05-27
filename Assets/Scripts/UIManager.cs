using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Animator TapToPlayAnimation;
    public Animator PanelToUpAnimation;
    public GameObject Score;

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
        PanelToUpAnimation.Play("ZigZagPanelUp");
        TapToPlayAnimation.SetTrigger("Call");
        Score.SetActive(true);
        Score.GetComponent<Text>().text = ScoreManager.instance.score.ToString();
    }
}
