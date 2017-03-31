using UnityEngine;
using System.Collections;

public class Shortcut : MonoBehaviour {


	private GameObject controller_test;
	private Controller_TEST script;

	private GameObject d;
	private Dreapta script2;

	public int nr;


	
	void Start()
	{


		controller_test = GameObject.Find("Controller_TEST");
		script = controller_test.GetComponent<Controller_TEST>();

		d = GameObject.Find("dreapta");
		script2 = d.GetComponent<Dreapta>();
	}


	IEnumerator OnMouseDown()
	{

		script2.Tata_Intrebari[script.nrIntrebare].transform.localPosition = script2.pos1;

		script2.text[script.nrIntrebare].SetActive(false);

		
		for(float f = 1; f>=0 ; f-=0.02f)
		{
			Color c = Color.white;
			c.a = f;
			script2.intrebari[script.nrIntrebare].color = c;
			yield return new WaitForSeconds(0.010f);
		}
		
		for(float f = 0; f<=1 ; f+=0.02f)
		{
			Color c = Color.white;
			c.a = f;
			script2.intrebari[nr].color = c;
			yield return new WaitForSeconds(0.010f);
		}
		
		script2.Tata_Intrebari[nr].transform.localPosition = script2.pos2;
		
		script2.text[nr].SetActive(true);
		
		
		
		script.nrIntrebare = nr;


	}



}
