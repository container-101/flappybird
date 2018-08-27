using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour {

    public int ScorePerPass = 10;

    void Start()
    {
  
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Count")
        {
            ScoreText.score += ScorePerPass;
        }
    }

}
