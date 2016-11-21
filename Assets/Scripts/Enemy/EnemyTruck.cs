using UnityEngine;
using System.Collections;

public class EnemyTruck : Enemy
{


    // Update is called once per frame
    void Update()
    {

    }


    void FixedUpdate()
    {
        _rb2d.velocity = new Vector2(0f, -speed);
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.tag == "enemy")
    //    {
    //        speed = other.GetComponent<Enemy>().speed;
    //    }
    //    else if (other.gameObject.tag != "item")
    //    {
    //        Explode();
    //    }
    //}

    public override void Explode() {
        Instantiate(explosionObj, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y), Quaternion.identity);
        Instantiate(explosionObj, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 2), Quaternion.identity);
        Instantiate(explosionObj, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y + 2), Quaternion.identity);
        Destroy(this.gameObject);
    }
}
