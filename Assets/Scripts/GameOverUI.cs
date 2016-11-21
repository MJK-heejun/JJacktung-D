using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour {

    public GameObject uiObj;

    private Player player;

    void Start()
    {
        uiObj.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    void Update()
    {


        if (player.curHealth <= 0)
        {
            //show the ui
            uiObj.SetActive(true);
            //Time.timeScale = 0;
        }
        else
        {
            //hide the ui
            uiObj.SetActive(false);
            //Time.timeScale = 1;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        //Application.LoadLevel(Application.loadedLevel); //reload current scene?

    }


}
