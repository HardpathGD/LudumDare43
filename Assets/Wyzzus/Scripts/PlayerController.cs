using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public Motor motor;
    public Interactable CurrentInteractable;
    public Item CurrentItem;
    public Text StatusBar;

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

        if (CurrentInteractable) 
        {
            if (Input.GetKeyDown(KeyCode.E))
                CurrentInteractable.Interact(gameObject);
            StatusBar.text = "Использовать " + CurrentInteractable.Name;
        }
        else
        {
            StatusBar.text = "";
        }

	}

    public void Move()
    {
        Vector3 pnt = transform.position + new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        motor.Move(pnt);
    }

	public void OnTriggerEnter(Collider other)
	{
        if(other.GetComponent<Interactable>() != null)
        {
            CurrentInteractable = other.GetComponent<Interactable>();
        }
	}

    public void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Interactable>() != null)
        {
            CurrentInteractable = null;
        }
    }


}
