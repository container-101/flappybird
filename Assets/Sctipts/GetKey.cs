using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{

    public GameObject myGameObject;
    public Rigidbody myRigidBody;
    public float JumpScale;
    public float ForScale;
    private int nowPosition;


    // Use this for initialization
    void Start()
    {

        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            PlayerJump();
        if (Input.GetKeyDown(KeyCode.RightArrow))
            PlayerRight();
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            PlayerLeft();
    }

    private void PlayerJump()
    {
        myRigidBody.AddForce(Vector3.up * JumpScale);
        myRigidBody.AddForce(Vector3.forward * ForScale);
    }
    private void PlayerLeft()
    {
        if (nowPosition > -1)
        {
            transform.Translate(new Vector3(-2, 0, 0));
            nowPosition--;
        }
    }
    public void PlayerRight()
    {
        if (nowPosition < 1)
        {
            transform.Translate(new Vector3(2, 0, 0));
            nowPosition++;
        }
    }
}