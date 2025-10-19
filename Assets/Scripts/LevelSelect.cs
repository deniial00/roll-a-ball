using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {


	public GameObject StandaloneUI;
	public GameObject MobileUI;
	void Start()
	{
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {
			Debug.Log ("App running on Mobile device!");
			MobileUI.SetActive (true);
			StandaloneUI.SetActive (false);
		} else if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer) {
			Debug.Log ("App running on a Computer!");
			MobileUI.SetActive (false);
			StandaloneUI.SetActive (true);
		}
	}

}
	