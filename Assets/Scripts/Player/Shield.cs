using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

    private Player player;

    // Use this for initialization
    void Start () {
        player = gameObject.GetComponentInParent<Player>();
    }
	
	// Update is called once per frame
	void Update () {
        
        var renderer = gameObject.GetComponent<SpriteRenderer>();

        if(player.isInvincible)
            renderer.enabled = true;
        renderer.enabled = player.isInvincible ? true : false;

        renderer.flipX = !renderer.flipX;
	}
}
