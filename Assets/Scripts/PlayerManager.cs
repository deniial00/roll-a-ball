using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;
	public float destroyTime = 3;
	public float loseTime = 3;

	private Rigidbody rb;
	private int count;
	private int nextScene;
	private float moveHorizontal;
	private float moveVertical;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		nextScene = SceneManager.GetActiveScene ().buildIndex + 1;
		print (nextScene);
		count = 0;
		SetCountText ();
		winText.text = "";

	}

	void FixedUpdate ()
	{
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) 
		{
			moveHorizontal = Input.acceleration.x;
			moveVertical = Input.acceleration.y;
		}
		else if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer )
		{
			moveHorizontal = Input.GetAxis ("Horizontal");
			moveVertical = Input.GetAxis ("Vertical");
		}
		Vector3 movement = new Vector3 (moveHorizontal, 0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	IEnumerator destroyWin()
	{
		yield return new WaitForSeconds (destroyTime);
		Destroy (winText);
		SceneManager.LoadScene (nextScene);
	}

	IEnumerator destroyLose()
	{
		yield return new WaitForSeconds (loseTime);
		Destroy (winText);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex) ;
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}

		if(other.gameObject.CompareTag("Walls") && count != 12)
		{
			count = 0;
			winText.text = "Game Over";
			StartCoroutine (destroyLose());
		}
	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) 
		{
			winText.text = "You Win!";
			StartCoroutine (destroyWin());

		}
	}
}