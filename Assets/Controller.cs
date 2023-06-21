using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
	public Text teksangka;
	public Text teksangka1;
	public Text teksangka2;
	public Text teksangka3;
	public Text pola2;
	public Text pola3;
	public Text pola4;
	int angkaInt;
	int angkaInt2;
	int angkaInt3;
	int angkaInt4;
	
	public void Start()
	{
		teksangka.text = StateNameController.angkalompat;
		teksangka1.text = "+ "+ StateNameController.angkalompat;
		teksangka2.text = "+ "+ StateNameController.angkalompat;
		teksangka3.text = "+ "+ StateNameController.angkalompat;

		int.TryParse(teksangka.text, out angkaInt);

		Debug.Log("angka setelah convert " + angkaInt);

		angkaInt2 = angkaInt + 1;
		angkaInt3 = angkaInt + angkaInt2;
		angkaInt4 = angkaInt + angkaInt3;


		pola2.text = angkaInt2.ToString();
		pola3.text = angkaInt3.ToString();
		pola4.text = angkaInt4.ToString();
	}

}
