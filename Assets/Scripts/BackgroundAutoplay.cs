using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BackgroundAutoplay : MonoBehaviour {

	void Start()
	{
		MovieTexture movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
		movie.Play ();
		movie.loop = true;
	}
}
