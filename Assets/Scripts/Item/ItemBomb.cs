using UnityEngine;
using System.Collections;

public class ItemBomb : MonoBehaviour {

    public float speed;
    protected Rigidbody2D _rb2d;

    // Use this for initialization
    void Start () {
        _rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate() {
        _rb2d.velocity = new Vector2(0f, -speed);
    }


    void OnTriggerEnter2D(Collider2D other)
    {        
        if (other.gameObject.tag == "Player")
        {
            GameObject[] enemyList = GameObject.FindGameObjectsWithTag("enemy");
            foreach (GameObject obj in enemyList)
            {
                obj.GetComponent<Enemy>().Explode();
            }
            Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            player.currentPoint += 2000;
            Destroy(this.gameObject);
        }
    }


}
