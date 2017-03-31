using UnityEngine;
using System.Collections;

public class Aplica : MonoBehaviour {




	public GameObject ctrl;
	private Tranzitie_Fundaluri script;

	public GameObject scroll;
	private Scroll script2;

	public GameObject cam;
	private Animatie script3;
	void Start()
	{
		script = ctrl.GetComponent<Tranzitie_Fundaluri>();
		script2 = scroll.GetComponent<Scroll>();
		script3 = cam.GetComponent<Animatie>();
	}


	IEnumerator OnMouseDown()
	{
		PlayerPrefs.SetInt("timp_anim", script2.TIMP);

		if(PlayerPrefs.GetInt("Anim") == 0)
		{
			iTween.Stop();
			script3.stop();
			cam.transform.position = new Vector3(0,0,-9);
		}
		else 
		{
			iTween.Stop();
			cam.transform.position = new Vector3(0,0,-9);
			yield return new WaitForSeconds(1);
			script3.reload();

		}
		script.click();
	}








}
