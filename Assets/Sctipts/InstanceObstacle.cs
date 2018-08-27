using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceObstacle : MonoBehaviour {

    public Transform[] PrefabList = new Transform[7];
    public int HowManyConst;
    private int random;

	// Use this for initialization
	void Start () {
		for(int i=1; i<=HowManyConst;i++)
        {
            random = Random.Range(0, 7);
            Instantiate(PrefabList[random], new Vector3(0,0,i*5), PrefabList[0].rotation);
        }
	}

}
