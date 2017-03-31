using UnityEngine;
using System.Collections;

public class ImageShow : MonoBehaviour {
	
	public GameObject imagine;
	
	void OnMouseEnter() {

		imagine.SetActive (true);
	}
	void OnMouseExit() {
	
		imagine.SetActive (false);
	}
}
