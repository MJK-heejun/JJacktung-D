using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

    protected Rigidbody2D _rb2d;

    // Use this for initialization
    void Start () {
        _rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate() {
        _rb2d.velocity = new Vector2(0f, -3f);
    }
}
