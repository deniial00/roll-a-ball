using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour {

	public void LoadLevel1 () 
	{
		SceneManager.LoadScene ("1");
	}

	public void LoadLevel2 () 
	{
		SceneManager.LoadScene ("2");
	}

	public void LoadLevel3 () 
	{
		SceneManager.LoadScene ("3");
	}

	public void LoadLevel4 () 
	{
		SceneManager.LoadScene ("4");
	}
}
