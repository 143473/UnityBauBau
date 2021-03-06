using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//[CreateAssetMenu(menuName = "Game Manager")]

public class GameManager:MonoBehaviour
{

    [SerializeField] protected GameObject gameOverCanvas;
    [SerializeField] protected GameObject gameMenu;
    [SerializeField] protected GameObject score;

    private void Start()
    {
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void PlayAgain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void BackToMenu()
    {
        SceneManager.UnloadSceneAsync(1);
        SceneManager.LoadScene(0);
    }

    /*IEnumerator CountdownToStart()
    {
        var countdownTime = 3;
        while (countdownTime > 0)
        {
            Score.score = countdownTime;
            yield return new WaitForSecondsRealtime(1f);
            countdownTime--;
        }
        yield return new WaitForSecondsRealtime(1f);
    }*/

    private void Update()
    {
        if (gameOverCanvas.GetComponent<Canvas>().enabled != true && Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        }

    }
    
}