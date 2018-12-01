using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public float lerpTime = 0.5f;
    public Transform Target;

	// Use this for initialization
	void Start () {
        Target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Target)
            MoveToTarget(Target);
	}

    public void MoveToTarget(Transform target)
    {
        transform.position = Vector3.Lerp(transform.position, target.position, lerpTime);
    }
}
