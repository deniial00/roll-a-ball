using UnityEngine;
using System.Collections;

public class CheckForUpdate : MonoBehaviour {

	public Canvas UpdateButton;
	public Canvas UpdateText;
	public string Version = "1.6";

	void start()
	{
		UpdateText.enabled = false;
		UpdateButton.enabled = false;
		if (Version == "1.6") {
			Debug.Log ("Up to date");
			UpdateText.enabled = true;
		} else if (Version != "1.6") {
			Debug.Log ("Update avaible");
			UpdateButton.enabled = true;
		}
	}
}
