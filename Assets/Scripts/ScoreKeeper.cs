using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
    Player player;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Text>().text = "Score: " + player.currentPoint;
    }
}
