using UnityEngine;
using System.Collections;

public class Text : MonoBehaviour {


	public string login_cont = "ceva";
	public string login_parola;

	public GUIStyle style_login;

	public Transform camp_login, camp_parola;

	public Vector3 c, p;

	public Camera cam;

	public SpriteRenderer reg;
	private Fade_Click2 script;

	void Start()
	{
		script = reg.GetComponent<Fade_Click2>();
	}

	void Update()
	{
		c = cam.WorldToScreenPoint(camp_login.position);
		p = cam.WorldToScreenPoint(camp_parola.position);
		style_login.fontSize = Mathf.FloorToInt( c.x / 17.4f );
	}
	
	void OnGUI() 
	{
		if(script.ok && !script.ok_warning)
		{
		login_cont = GUI.TextField(new Rect(c.x - 175, Screen.height - c.y - 10, 350, 20), login_cont, 12, style_login);
		login_parola = GUI.PasswordField(new Rect(p.x - 175, Screen.height - p.y - 10, 350, 20), login_parola, "*"[0], 12, style_login);
		}
	}
}
