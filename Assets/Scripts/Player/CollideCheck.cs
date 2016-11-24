using UnityEngine;
using System.Collections;

public class CollideCheck : MonoBehaviour {

    private Player player;

    // Use this for initialization
    void Start () {
        player = gameObject.GetComponentInParent<Player>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "enemy")
        {
            if (!player.isInvincible)
                player.curHealth--;
            else
                player.currentPoint += 1000;
        }
            
    }

    //gets called when the trigger stays in something???
    void OnTriggerStay2D(Collider2D col)
    {
    }

    void OnTriggerExit2D(Collider2D col)
    {
    }


    // Update is called once per frame
    void Update () {
	
	}
}
