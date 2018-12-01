using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YUSHPlayerController : MonoBehaviour {

    private Rigidbody2D rb2d;
    public float speed = 5.0f;


    void Start () {

        rb2d = GetComponent<Rigidbody2D>();
	}


    private void Update(){

      transform.Translate (Input.GetAxis ("Horizontal") * speed, 0, 0);
  }


    void FixedUpdate () {
}


}
