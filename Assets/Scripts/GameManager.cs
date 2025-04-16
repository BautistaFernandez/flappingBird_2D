using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Reference for canvas.
    public GameObject gameoverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        // To start moving and no pause.
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Game over method.
    public void GameOver()
    {
        // Active canvas and pause game.
        gameoverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
