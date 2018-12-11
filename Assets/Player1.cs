using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {
    public string i;
    public float speed = 30;
	// Use this for initialization
	void Update () {
        float v = Input.GetAxisRaw(i) * speed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v);
	}
	
	// Update is called once per frame
}
