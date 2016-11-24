using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float playerSpeed;

    private Rigidbody2D rb2d;
    public Boundary boundary;
    public GameObject explosionObj;

    public int maxHealth;
    public int curHealth;

    public bool isInvincible = false;
    public int currentPoint = 0;


    // Use this for initialization
    void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}


    //updated for each physics step?
    void FixedUpdate() {
        
        if (curHealth <= 0) {
            Instantiate(explosionObj, new Vector2(gameObject.transform.position.x, this.gameObject.transform.position.y), Quaternion.identity);
            Destroy(this.gameObject);
        }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb2d.velocity = new Vector2(1f * playerSpeed, 0f);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb2d.velocity = new Vector2(-1f * playerSpeed, 0f);
            }
            else
            {
                rb2d.velocity = new Vector2(0f, 0f);
            }

            //readjust position - boundary
            rb2d.position = new Vector2(
                Mathf.Clamp(rb2d.position.x, boundary.xMin, boundary.xMax),
                Mathf.Clamp(rb2d.position.y, boundary.yMin, boundary.yMax));
        }
        currentPoint++;
    }

    public void ActivateShield() {
        StartCoroutine("ShieldActivation");
    }


    IEnumerator ShieldActivation()
    {
        isInvincible = true;
        yield return new WaitForSeconds(5);
        isInvincible = false;
    }

}



[System.Serializable]
public class Boundary {
    public float xMin, xMax, yMin, yMax;
}
