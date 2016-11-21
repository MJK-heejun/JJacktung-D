using UnityEngine;
using System.Collections;

public class EnemyNormalCar : Enemy {

    //// Use this for initialization
    //void Start () {
    //    _rb2d = gameObject.GetComponent<Rigidbody2D>();        
    //}
	

	// Update is called once per frame
	void Update () {
	    
	}


    void FixedUpdate()
    {        
        _rb2d.velocity = new Vector2(0f, -speed);
    }

}
