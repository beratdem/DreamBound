using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject gameOverScreen;

    public Text livesText;

    public Slider healthBar;

    public Text scoreText, hiScoreText;

    public Slider shieldBar;

    public GameObject levelEndScreen;

    public Text endLevelScore, endCurrentScore;
    public GameObject highScoreNotice;

    public GameObject pauseScreen;

    public string mainMenuName = "MainMenu";

    public Slider bossHealthSlider;
    public Text bossName;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void QuitToMain()
    {
        SceneManager.LoadScene(mainMenuName);
        Time.timeScale = 1f;
    }

    public void Resume()
    {
        GameManager.instance.PauseUnpause();
    }
}
