using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeksHasil : MonoBehaviour
{
    Text teks;
    public string after_text;

   public float delay;
    void Start()
    {
        teks = gameObject.GetComponent<Text>();
        StartCoroutine(hasil());
    }

    public IEnumerator hasil(){
    	yield return new WaitForSeconds(delay);
    	teks.text = after_text;
    	
    }
}
