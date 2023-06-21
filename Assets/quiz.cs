using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class quiz : MonoBehaviour
{
	public GameObject benar;
	public GameObject salah;
	public GameObject nextbutton;
	public Text pola;
	public GameObject inputField;
	public Text teksangka1;
	public Text teksangka2;
	public Text teksangka3;
	public Text teksangka4;
	public int minRange;
	public int maxRange;
	public int minStart;
	public int maxStart;
	int angkaInt1;
	int angkaInt2;
	int angkaInt3;
	int angkaInt4;
	int randomNumber;

	int jawabanInt;

	string jawaban;

	public void Start()
	{
		off();
		randomNumber = Random.Range(minRange, maxRange);
		Debug.Log("Random " + randomNumber);

		angkaInt1 = Random.Range(minStart, maxStart);
		angkaInt2 = angkaInt1 + randomNumber;
		angkaInt3 = angkaInt2 + randomNumber;
		angkaInt4 = angkaInt3 + randomNumber;

		pola.text = "Bilangan loncat berpola "+randomNumber.ToString();
		teksangka1.text = angkaInt1.ToString();
		teksangka2.text = angkaInt2.ToString();;
		teksangka3.text = angkaInt3.ToString();
		teksangka4.text = angkaInt4.ToString();
	}

	public void off(){
		benar.SetActive(false);
		salah.SetActive(false);
		nextbutton.SetActive(false);
	}


	public void soal1()
	{
		off();
		angkaInt2 = angkaInt1 + randomNumber;
		jawaban = inputField.GetComponent<Text>().text;
		int.TryParse(jawaban, out jawabanInt);

		if(angkaInt2 == jawabanInt)
		{
			Debug.Log("betul betul betul " +jawabanInt);
			benar.SetActive(true);
			nextbutton.SetActive(true);
		}
		else if(jawabanInt == 0 )
		{
			Debug.Log("null");
		}
		else
		{
			Debug.Log("nope " +jawabanInt);
			salah.SetActive(true);
		}	
	}

	public void soal2()
	{
		off();
		jawaban = inputField.GetComponent<Text>().text;
		int.TryParse(jawaban, out jawabanInt);

		if(angkaInt3 == jawabanInt)
		{
			Debug.Log("betul betul betul " +jawabanInt);
			benar.SetActive(true);
			nextbutton.SetActive(true);
		}
		else if(jawabanInt == 0 )
		{
			Debug.Log("null");
		}
		else
		{
			Debug.Log("nope " +jawabanInt);
			salah.SetActive(true);
		}	
	}

	public void soal4()
	{
		off();
		jawaban = inputField.GetComponent<Text>().text;
		int.TryParse(jawaban, out jawabanInt);

		if(randomNumber == jawabanInt)
		{
			Debug.Log("betul betul betul " +randomNumber+jawabanInt);
			benar.SetActive(true);
			nextbutton.SetActive(true);
		}
		else if(jawabanInt == 0 )
		{
			Debug.Log("null");
		}
		else
		{
			Debug.Log("nope " +jawabanInt);
			salah.SetActive(true);
		}	
	}
}