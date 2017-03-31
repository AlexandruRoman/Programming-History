using UnityEngine;
using System.Collections;

public class Verifica_test : MonoBehaviour {


	public GameObject controller_test;
	private Controller_TEST script;

	public GameObject camp_scor, camp_timpfinal;
	private TextMesh text_scor, text_timpfinal;

	public GameObject s,d;
	
	private Dreapta script2;


	IEnumerator OnMouseDown()
	{
		s.GetComponent<Collider2D>().enabled = false;
		d.GetComponent<Collider2D>().enabled = false;

				
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
					script2.intrebari[script.nrIntrebare + 1].color = c;
					yield return new WaitForSeconds(0.010f);
				}
				
		script2.text[19].SetActive(true);


		script.calculare_scor();
		yield return new WaitForSeconds(1);

		text_scor.text = "Scorul tau: " + (script.scor + 2) + " / 20";
		text_timpfinal.text = "Timpul tau: " + script.min + " : " + (script.sec - script.min*60);

	}


	void Start()
	{
		text_scor = camp_scor.GetComponent<TextMesh>();
		text_timpfinal = camp_timpfinal.GetComponent<TextMesh>();

		script = controller_test.GetComponent<Controller_TEST>();
		script2 = d.GetComponent<Dreapta>();
	}


}
