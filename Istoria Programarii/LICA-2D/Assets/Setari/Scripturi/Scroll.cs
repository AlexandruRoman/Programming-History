using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	float poz = 0;
	float timp;
	public int TIMP;
	public GUIStyle style;


	private Vector3 v;

	public GUISkin skin;

	public Transform t;

	bool ok = true;



	void Start()
	{
		timp = 60 - PlayerPrefs.GetInt("timp_anim");
		v = transform.position;
	}
                                              

	void OnGUI()
	{
		GUI.skin = skin;
		poz = GUI.VerticalScrollbar(new Rect(Screen.width - 25, 0, 80, Screen.height), poz, 6.0F, 101, 0.0F);

		if(poz > 101 - 7)
		{
			timp = GUI.HorizontalScrollbar(new Rect(Screen.width*18.25f/30 - 125, Screen.height - Screen.height*4/22, 250, 50), timp, 1, 56, 0);
			TIMP = 60 - (int)timp;
			GUI.TextArea(new Rect(Screen.width*18.25f/30 - 125, Screen.height - Screen.height*4/22 - 40, 250, 30), "" + TIMP + " (sec)");
		}

	}



	void Update()
	{
		transform.position = new Vector3(t.position.x, (poz)/2.3f + t.position.y -v.y, t.position.z);
	}

}
