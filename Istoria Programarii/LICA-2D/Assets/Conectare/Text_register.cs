using UnityEngine;
using System.Collections;

public class Text_register : MonoBehaviour {

	public string register_nume;
	public string register_prenume;
	public string register_cont;
	public string register_parola;
	
	public GUIStyle style_login;
	
	public Transform camp_nume, camp_prenume, camp_cont, camp_parola;
	
	private Vector3 poz_nume, poz_prenume, poz_cont, poz_parola;
	
	public Camera cam;
	
	public SpriteRenderer reg;
	private Fade_Click2 script;
	
	void Start()
	{
		script = reg.GetComponent<Fade_Click2>();
	}
	
	void Update()
	{
		poz_nume = cam.WorldToScreenPoint(camp_nume.position);
		poz_prenume = cam.WorldToScreenPoint(camp_prenume.position);
		poz_cont = cam.WorldToScreenPoint(camp_cont.position);
		poz_parola = cam.WorldToScreenPoint(camp_parola.position);
		
		style_login.fontSize = Mathf.FloorToInt( poz_nume.x / 14.4f );
	}
	
	void OnGUI() 
	{
		if(!script.ok && !script.ok_warning)
		{
			register_nume = GUI.TextField(new Rect(poz_nume.x - 175, Screen.height - poz_nume.y - 10, 350, 20), register_nume, 12, style_login);
			register_prenume = GUI.TextField(new Rect(poz_prenume.x - 175, Screen.height - poz_prenume.y - 10, 350, 20), register_prenume, 12, style_login);
			register_cont = GUI.TextField(new Rect(poz_cont.x - 175, Screen.height - poz_cont.y - 10, 350, 20), register_cont, 12, style_login);
			register_parola = GUI.PasswordField(new Rect(poz_parola.x - 175, Screen.height - poz_parola.y - 10, 350, 20), register_parola, "*"[0], 12, style_login);

		}
	}
}
