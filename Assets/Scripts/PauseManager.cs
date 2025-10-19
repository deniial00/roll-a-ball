using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

	public Canvas PauseMenu;
	private bool paused;
	private bool muted;	
	[SerializeField]
	Text mutetext;

	void Start () {
		PauseMenu.enabled = false;
		Cursor.visible = false;
		Time.timeScale = 1;
	}

	void Update () 
	{
		if(Input.GetKeyUp("escape")) {
			if(Time.timeScale == 1) {
				Time.timeScale = 0;
				PauseMenu.enabled = true;
				Cursor.visible = true;		
			} else {
				Time.timeScale = 1;
				PauseMenu.enabled = false;
				Cursor.visible = false;		
			}
		}

	}

	public void PauseButton()
	{
		if (Time.timeScale == 1) {
			PauseMenu.enabled = true;
			Time.timeScale = 0;
			Cursor.visible = true;
		} 
		else 
		{
			PauseMenu.enabled = false;
			Time.timeScale = 1;
			Cursor.visible = false;
		}
	}

	public void Resume()
	{
		PauseMenu.enabled = false;
		Time.timeScale = 1.0f;
		Cursor.visible = false;
	}

	public void MainMenu()
	{
		SceneManager.LoadScene("main_menu");
	}

	public void Mute()
	{
		if (AudioListener.volume >= 0.15f) {
			AudioListener.volume = 0;
		} else {
			AudioListener.volume = 1f;
		}
	}


}
