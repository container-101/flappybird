using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveButton : MonoBehaviour {

    public Rigidbody myRigidBody;
    public float jumpScale;
    public float forScale;
    private int nowPosition;

    void Start()
    {
        nowPosition = 0;
        myRigidBody = GetComponent<Rigidbody>();   
    }

    public void playerJump()
    {
        myRigidBody.AddForce(Vector3.up * jumpScale);
        myRigidBody.AddForce(Vector3.forward * forScale);
    }
    public void playerLeft()
    {
        if (nowPosition > -1)
        {
            transform.Translate(new Vector3(-2, 0, 0));
            nowPosition--;
        }
    }
    public void playerRight()
    {
        if (nowPosition < 1)
        {
            transform.Translate(new Vector3(2, 0, 0));
            nowPosition++;
        }
    }

}
