using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	public Text inputField;

    public void GoBack(int sceneberapa)
    {
        SceneManager.LoadScene(sceneberapa);
    }
    public void hitung(int sceneberapa)
    {

    	if(inputField.text == "")
    	{
   			Debug.Log("field is empty");
    	}

    	else
    	{
        	SceneManager.LoadScene(sceneberapa);
    	}
    }
}
