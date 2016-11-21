using UnityEngine;
using System.Collections;
using System;

public class ItemShield : MonoBehaviour {
    
    public float speed;
    protected Rigidbody2D _rb2d;

    private Player player;

    // Use this for initialization
    void Start()
    {
        _rb2d = gameObject.GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        _rb2d.velocity = new Vector2(0f, -speed);
        try
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        }
        catch (NullReferenceException ex) {
            Debug.Log("item creation failed due to missing player object");
            Destroy(this.gameObject);
        }
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.ActivateShield();
            Destroy(this.gameObject);
        }
    }


}
