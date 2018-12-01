using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YUSHJuicerScript : MonoBehaviour {

public GameObject JuiceParticle;


	void Start () {

	}


	void Update () {

	}



	void OnTriggerEnter2D(Collider2D other)
	{
			if (other.gameObject.CompareTag("Pickup"))
			other.gameObject.SetActive(false);
			Instantiate(JuiceParticle, other.transform.position, other.transform.rotation);


	}



}
