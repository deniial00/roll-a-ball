using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour {

	public Canvas CreditMobile;
	public Canvas CreditStandalone;
	void Start()
	{
		if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.Android) {
			CreditMobile.enabled = true;
			CreditMobile.enabled = false;
			Debug.Log ("Running on Mobile device");
		}else{
			CreditStandalone.enabled = false;
			CreditStandalone.enabled = true;
			Debug.Log ("Running on Standalone device");
		}
	}

	public void MainMenuBtn()
	{
		SceneManager.LoadScene ("main_menu");
	}
}
