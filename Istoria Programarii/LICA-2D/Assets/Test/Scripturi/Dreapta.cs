using UnityEngine;
using System.Collections;

public class Dreapta : MonoBehaviour {


	public GameObject controller;
	private Controller_TEST script;

	public GameObject stanga;

	public Material[] intrebari;

	public GameObject[] text;

	public GameObject[] Tata_Intrebari;

	public Vector3 pos1, pos2;

	void Start()
	{
		pos1 = Tata_Intrebari[0].transform.localPosition;

		pos2 = new Vector3(pos1.x, pos1.y, pos1.z -0.05f);

		Tata_Intrebari[0].transform.localPosition = pos2;

		script = controller.GetComponent<Controller_TEST>();

		Color c = Color.white;

		intrebari[0].color = c;
		text[0].SetActive(true);

		c.a = 0;

		for(int i=1;i< intrebari.Length;i++)
		{
			intrebari[i].color = c;
			text[i].SetActive(false);
		}
	}

	IEnumerator OnMouseDown()
	{
		Tata_Intrebari[script.nrIntrebare].transform.localPosition = pos1;

		text[script.nrIntrebare].SetActive(false);

		stanga.GetComponent<Collider2D>().enabled = false;
		gameObject.GetComponent<Collider2D>().enabled = false;



		for(float f = 1; f>=0 ; f-=0.02f)
		{
			Color c = Color.white;
			c.a = f;
			intrebari[script.nrIntrebare].color = c;
			yield return new WaitForSeconds(0.01f);
		}

		for(float f = 0; f<=1 ; f+=0.02f)
		{
			Color c = Color.white;
			c.a = f;
			intrebari[script.nrIntrebare + 1].color = c;
			yield return new WaitForSeconds(0.01f);
		}

		Tata_Intrebari[script.nrIntrebare + 1].transform.localPosition = pos2;

		stanga.GetComponent<Collider2D>().enabled = true;
		gameObject.GetComponent<Collider2D>().enabled = true;

		text[script.nrIntrebare + 1].SetActive(true);


		
		script.nrIntrebare++;
	}






}
