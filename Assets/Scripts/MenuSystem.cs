using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuSystem : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("highscore").ToString();
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Level");
    }

}
