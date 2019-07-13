using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Motor : MonoBehaviour {

    public NavMeshAgent agent;
    public float BaseSpeed;
    public float CurrentSpeed;

	// Use this for initialization
	void Start () 
    {
        agent = GetComponent<NavMeshAgent>();
        CurrentSpeed = BaseSpeed; 
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(agent)
        {
            agent.speed = CurrentSpeed;
        }
	}

    public void Move(Vector3 point)
    {
        agent.destination = point;
    }

    public void ResetSpeed()
    {
        CurrentSpeed = BaseSpeed;
    }

    public void SetCurrentSpeed(float newSpeed)
    {
        CurrentSpeed = newSpeed;
    }


}
