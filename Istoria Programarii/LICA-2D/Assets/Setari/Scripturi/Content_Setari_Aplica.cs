using UnityEngine;
using System.Collections;

public class Content_Setari_Aplica : MonoBehaviour {


	float niv;
	public GUISkin skin;

	public GameObject check;
	private Content_Setari_Check script;

	void Start()
	{
		script = check.GetComponent<Content_Setari_Check>();
	}

	void OnGUI()
	{
		GUI.skin = skin;
		niv = GUI.HorizontalScrollbar(new Rect(Screen.width*18.25f/30 - 125, 70, 250, 50), niv, 1, 1, 4);

		GUI.TextArea(new Rect(Screen.width*18.25f/30 - 125, 25, 250, 50), "Nivel Calitate: " + (int)niv);
	}

	void OnMouseDown()
	{
		if((int)niv == 1)
			QualitySettings.SetQualityLevel(1);

		if((int)niv == 2)
			QualitySettings.SetQualityLevel(3);

		if((int)niv == 3)
			QualitySettings.SetQualityLevel(6);


		if(script.ok == true)
		{
			PlayerPrefs.SetInt("full", 1);
			Screen.SetResolution(1280, 1024, true);
		}
		else
		{
			PlayerPrefs.SetInt("full", 0);
			Screen.SetResolution(900, 720, false);
		}
	}

}
