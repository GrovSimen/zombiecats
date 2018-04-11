using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame ()
    {
		Data.Bones = 0;
		Data.Coins = 0;
		Data.GoldenBones = 0;
        SceneManager.LoadScene("tut_map");
    }

    public void QuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
