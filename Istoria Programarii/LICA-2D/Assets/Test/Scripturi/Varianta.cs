using UnityEngine;
using System.Collections;

public class Varianta : MonoBehaviour {


	public GameObject dialog;
	public int nr;

	private GameObject controller_test;
	private Controller_TEST script;

	void Start()
	{
		controller_test = GameObject.Find("Controller_TEST");
		script = controller_test.GetComponent<Controller_TEST>();
	}


	void OnMouseDown()
	{
		dialog.transform.position = transform.position;

		if(script.corect[script.nrIntrebare] == nr)
		{
			script.ok[script.nrIntrebare] = true;
		}

		else
		{
			script.ok[script.nrIntrebare] = false;
		}
	}





}
