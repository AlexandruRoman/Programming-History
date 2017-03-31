using UnityEngine;
using System.Collections;

public class Completare : MonoBehaviour {


	public GUIStyle stil;

	public string corect;
	public string text = "";

	private GameObject controller_test;
	private Controller_TEST script;

	void Start()
	{
		controller_test = GameObject.Find("Controller_TEST");
		script = controller_test.GetComponent<Controller_TEST>();
	}


	void OnGUI()
	{

		text = GUI.TextField(new Rect(Screen.width - 600, Screen.height/2 - 35, 500, 50), text, 35,stil);

		if(corect == text.ToLower())
		{
			script.ok[script.nrIntrebare] = true;
		}
		
		else
		{
			script.ok[script.nrIntrebare] = false;
		}

	}




}
