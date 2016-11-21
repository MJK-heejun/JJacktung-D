using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float speed;
    protected Rigidbody2D _rb2d;


    public GameObject explosionObj;

    // Use this for initialization
    void Start()
    {
        _rb2d = gameObject.GetComponent<Rigidbody2D>();
        gameObject.transform.Rotate(0,0,90);    

    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            if (gameObject.transform.position.y < 7)
                Explode();
            speed = other.GetComponent<Enemy>().speed;
        }else if(other.gameObject.tag != "item" && other.gameObject.tag != "Finish")
        {
            Explode();
        }
    }

    public virtual void Explode() {
        Instantiate(explosionObj, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y), Quaternion.identity);
        Destroy(this.gameObject);
    }

}
