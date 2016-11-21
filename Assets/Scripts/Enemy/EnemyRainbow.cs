using UnityEngine;
using System.Collections;

public class EnemyRainbow : Enemy
{
    private bool newValAvailable = false;
    private float newSpeed;
    

    // Update is called once per frame
    void Update()
    {

    }


    void FixedUpdate()
    {

        if (newValAvailable)
            _rb2d.velocity = new Vector2(0f, -newSpeed);
        else {
            float mySpeed = speed * 2f;
            _rb2d.velocity = new Vector2(0f, -mySpeed);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            if (gameObject.transform.position.y < 7)
                Explode();
            newValAvailable = true;
            newSpeed = other.GetComponent<Enemy>().speed;
        }
        else if (other.gameObject.tag != "item" && other.gameObject.tag != "Finish")
        {
            Explode();
        }
    }

}
