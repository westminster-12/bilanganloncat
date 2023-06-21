using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{

	public void quitonclick(){

		 Application.Quit();
		Debug.Log ("You have clicked the button!");
		//UnityEditor.EditorApplication.isPlaying = false;
		//EditorApplication.Exit(0);
	}
}
