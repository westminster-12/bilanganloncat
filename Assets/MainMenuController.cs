using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
	public string angka;
	public GameObject inputField;

	public void simpanangka(){
		angka = inputField.GetComponent<Text>().text;
		Debug.Log("Text: " + angka);
		StateNameController.angkalompat  = angka;
	}

}
