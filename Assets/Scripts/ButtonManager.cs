using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {
	
	public Canvas CreditMobile;
	public Canvas CreditStandalone;

	public Canvas MainMenuUI;

	public Canvas SelectStandalone;
	public Canvas SelectMobile;

	void Start()
	{
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {
			Debug.Log ("Running on mobile device");
		} else if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer) {
			Debug.Log ("Running on standalone device");
		}
		CreditMobile.enabled = false;
		CreditStandalone.enabled = false;

		SelectMobile.enabled = false;
		SelectStandalone.enabled = false;
	}
		
	public void newGameBtn(string newGameLevel)
	{
		SceneManager.LoadScene ("1");
	}

	public void levelSelecter ()
	{
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {
			SelectMobile.enabled = true;				
			SelectStandalone.enabled = false;
			MainMenuUI.enabled = false;
		} else if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer) {
			SelectMobile.enabled = false;
			SelectStandalone.enabled = true;
			MainMenuUI.enabled = false;
		}
	}
	public void exitGameBtn()
	{
		Application.Quit();
	}
	public void credits()
	{
			if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.Android) {
				CreditMobile.enabled = true;
				CreditStandalone.enabled = false;	
				MainMenuUI.enabled = false;
		} else if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer) {
				CreditStandalone.enabled = true;
				CreditMobile.enabled = false;
				MainMenuUI.enabled = false;
			}
	}

	public void MainMenuCredits()
	{
		SceneManager.LoadScene ("main_menu");
	}
}
