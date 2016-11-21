using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Sprite[] HeartSprites;

    public Image HeartUI;

    private Player player;



    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.curHealth, null);
        if(player.curHealth >= 0 && player.curHealth <= 5 )
           HeartUI.sprite = HeartSprites[player.curHealth];
    }
}
