using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FirstScene : MonoBehaviour {

    public GameObject uiObj;

    void Start()
    {
        //uiObj.SetActive(false);
    }

    void Update()
    {
    }

    public void StartPlaying()
    {
        SceneManager.LoadScene(0);
    }

}
