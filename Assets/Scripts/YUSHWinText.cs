using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YUSHWinText : MonoBehaviour {

	public GameObject TextObj;
	     float TmStart;
	     float TmLen=12f;


	     void Start () {
	         TmStart=Time.time;
	     }

	     void Update () {
	         if(Time.time>TmStart + TmLen)
	         {

	             TextObj.SetActive (true);
	         }
	     }

}
