using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Motor motor;

	// Use this for initialization
	void Start () {
        motor = GetComponent<Motor>();
	}
	
    public float Speed = 1f;
    public float Turn;

	// Update is called once per frame
	void Update () 
    {
        Move();
        if (Input.GetKey(KeyCode.LeftShift))
            motor.SetCurrentSpeed(motor.BaseSpeed * 1.5f);
        else
            motor.ResetSpeed();
	}

    public void Move()
    {
        Vector3 pnt = transform.position + new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        motor.Move(pnt);
    }


}
