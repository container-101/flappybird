using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    public Button StartButton;
    public Button[] ActiveButton = new Button[3];

    void Start () {
        Time.timeScale = 0;
	}

    public void PauseGame()
    {
        Time.timeScale = 1.0F;
        StartButton.gameObject.SetActive(false);
        ActiveButton[0].gameObject.SetActive(true);
        ActiveButton[1].gameObject.SetActive(true);
        ActiveButton[2].gameObject.SetActive(true);
    }
}
