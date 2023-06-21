using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
     Animation anim;
    //Animator anim;
    public float delay;
    void Start()
    {
        transform.localScale = new Vector3 (0,0,0);
    	anim = gameObject.GetComponent<Animation>();
        StartCoroutine(popanim());
    }

    public IEnumerator popanim(){
    	yield return new WaitForSeconds(delay);
    	anim.Play("New Animation");
    }
}
