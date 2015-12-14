using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Win") {
			GetComponent<AudioSource>().Play();
			Invoke("Reload",5);

		}

	}


	void Reload(){
		Application.LoadLevel(Application.loadedLevel);
	}
}
