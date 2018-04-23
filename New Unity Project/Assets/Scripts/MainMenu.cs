using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("map1");

		Debug.Log ("Welp!");
	}

    public void QuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("tut_map");
    }
}
