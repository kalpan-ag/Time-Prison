using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
	public void LevelSelect(string scene)
	{
		Application.LoadLevel(scene);
	}
	public void QuitGame()
    {
		Application.Quit();
    }
}
