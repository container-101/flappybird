using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public Button[] DeactiveButton = new Button[3];
    public Button ResetButton;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            DeactiveButton[0].gameObject.SetActive(false);
            DeactiveButton[1].gameObject.SetActive(false);
            DeactiveButton[2].gameObject.SetActive(false);
            ResetButton.gameObject.SetActive(true);
        }
    }

}
