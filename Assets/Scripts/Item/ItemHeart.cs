using UnityEngine;
using System.Collections;

public class ItemHeart : MonoBehaviour {

    public float speed;
    protected Rigidbody2D _rb2d;

    // Use this for initialization
    void Start()
    {
        _rb2d = gameObject.GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update () {
	
	}

    void FixedUpdate()
    {
        _rb2d.velocity = new Vector2(0f, -speed);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            int currentHealth = player.curHealth;
            if (currentHealth < 5)
                player.curHealth++;
            Destroy(this.gameObject);
        }
    }
}
