using UnityEngine;
using System.Collections;

public class Trimitere : MonoBehaviour {


	bool ok = false;
	public string catre;

	IEnumerator OnMouseDown()
	{
		yield return new WaitForSeconds(4);
		if(ok == false)
			Application.LoadLevel(catre);
		else
			Application.LoadLevelAsync(catre);
	}



}
