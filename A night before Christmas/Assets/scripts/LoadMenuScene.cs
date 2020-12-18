using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenuScene : MonoBehaviour
{
	 private string sceneName = "Menu";
	public void LoadScene()
	{
		SceneManager.LoadScene(sceneName);
	}
}
