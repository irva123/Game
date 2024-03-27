using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {
	public float speed;
	public Text skor;
	public static int score = 0;
	//use this for initialisation
	

	
	void OnTriggerEnter(Collider obj){
		if(obj.gameObject.tag == "target") {
			Destroy (obj.gameObject);
			score += 25;
			skor.text = "Skor : " + score.ToString ();
			GameObject.Find ("Suara_Point").GetComponent<AudioSource>().Play();
		}
		
}

	}
