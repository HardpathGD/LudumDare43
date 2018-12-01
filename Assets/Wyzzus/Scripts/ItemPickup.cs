using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactable {

    public Item ItemData;

	// Use this for initialization
	public override void Start()
	{
        base.Start();

        Name = ItemData.Name;
	}

	// Update is called once per frame
	void Update () {
		
	}

	public override void Interact(GameObject user)
	{
        base.Interact(user);

        Pickup(user);
	}

    public void Pickup(GameObject user)
    {
        Debug.Log(user.name + " picks up " + ItemData.Name);

        Inventory userInv = user.GetComponent<Inventory>();
        userInv.CurrentItem = ItemData;
        Destroy(gameObject);
    }
}
