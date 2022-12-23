using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogisticScript : MonoBehaviour
{
   public int score;
   public Text scoreText;
   public GameObject gameoverscreen;

    [ContextMenu("Add Score")]
    public void addScore(int ScoreToAdd)
    {

        score = score + ScoreToAdd;
        scoreText.text = score.ToString();

    }

    public void restarGame()
    {
        Debug.Log("RestarButton Pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
            gameoverscreen.SetActive(true);
    }

}



