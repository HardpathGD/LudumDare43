using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    public SphereCollider InteractionTrigger;

    public float InteractionRadius = 1f;

    public string Name = "Interactable";

	// Use this for initialization
	public virtual void Start () 
    {
        InteractionTrigger = GetComponent<SphereCollider>();
        InteractionTrigger.isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () 
    {
        //InteractionTrigger.radius = InteractionRadius;
	}

    public virtual void Interact(GameObject user)
    {
        Debug.Log(user.name + " interacts with " + Name);
    }
}
