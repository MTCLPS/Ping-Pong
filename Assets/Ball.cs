using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float speed = 30;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Player1")
        {
            float dis = (transform.position.y - col.transform.position.y) / col.collider.bounds.size.y;
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, dis) * speed;
        }
        if (col.gameObject.name == "Player2")
        {
            float dis = (transform.position.y - col.transform.position.y) / col.collider.bounds.size.y;
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, dis) * speed;
        }
    }

}
