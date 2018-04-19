using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
	public int counter;

	// Update is called once per frame
	void Update () {
		counter = 0;
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
		counter++;
		print (counter);
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
		counter++;
		print (counter);
    }

    public void LoadOptions()
    {
        Debug.Log("Loading options..");
        SceneManager.LoadScene("OptionsMenu");
    }

    public void ExitToMenu()
    {
        Debug.Log("Loading menu..");
        SceneManager.LoadScene("Menu");
    }
}
