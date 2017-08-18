using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KenaObjek : MonoBehaviour {

	// Use this for initialization
	public string nameTag;
	public AudioClip audioBenar;
	public AudioClip audioSalah;
	private AudioSource MediaPlayerBenar;
	private AudioSource MediaPlayerSalah;
	public int score;
	//public Text textScore;

	// Use this for initialization
	void Start () {
		MediaPlayerBenar = gameObject.AddComponent<AudioSource> ();
		MediaPlayerBenar.clip = audioBenar;
		MediaPlayerSalah = gameObject.AddComponent<AudioSource> ();
		MediaPlayerSalah.clip = audioSalah;

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag.Equals (nameTag)) {
			Data.score += 2;
			score = Data.score;
			//textScore.text = Data.score.ToString ();
			Destroy (collision.gameObject);
			MediaPlayerBenar.Play ();
		} else {
			Data.score -= 1;
			score = Data.score;
			//textScore.text = Data.score.ToString ();
			Destroy (collision.gameObject);
			MediaPlayerSalah.Play ();
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
