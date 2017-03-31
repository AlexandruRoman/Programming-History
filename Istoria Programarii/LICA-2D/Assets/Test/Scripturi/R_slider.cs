using UnityEngine;
using System.Collections;

public class R_slider : MonoBehaviour {




	private GameObject controller_test;
	private Controller_TEST script;



	public GUISkin skin;

	public int corect;

	float an = 1900;


	void Start()
	{
		controller_test = GameObject.Find("Controller_TEST");
		script = controller_test.GetComponent<Controller_TEST>();
	}


	void OnGUI()
	{
		GUI.skin = skin;


		an = GUI.HorizontalScrollbar(new Rect(Screen.width/2 - 150, Screen.height/2 - 30, 300, 30), an, 10, 1900, 2024);

		GUI.TextArea(new Rect(Screen.width/2 - 150, Screen.height/2 , 300, 30), "Anul: " + (int)an);

		if(corect == (int)an)
			script.ok[script.nrIntrebare] = true;

		else 
			script.ok[script.nrIntrebare] = false;
	}
}
