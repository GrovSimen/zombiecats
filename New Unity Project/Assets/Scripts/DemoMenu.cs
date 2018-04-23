using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemoMenu : MonoBehaviour {

	public void PlayDemo ()
    {
        SceneManager.LoadScene("tut_map");
    }

    public void QuitDemo ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

	public void QuitToMenu(){
		SceneManager.LoadScene ("DemoMenu");
	}
		
}
