using UnityEngine;
using System.Collections;

public class SquishPlayer : MonoBehaviour {
	public AudioClip[] sounds;
	public AudioSource soundFile;
	public static SquishPlayer InstanceAudio;

	// Use this for initialization
	void Start () {
		InstanceAudio = this;

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void RandomSquishPlayer()
	{
		soundFile.clip = sounds [Random.Range (0, sounds.Length)];
		soundFile.Play ();
		Debug.Log ("Sound played");
	}
}
