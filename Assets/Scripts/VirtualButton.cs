﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler {

	private VirtualButtonBehaviour virtualBtn; 

	public Animator birdAnim; 

	public void OnButtonPressed(VirtualButtonBehaviour vh){

		birdAnim.SetTrigger("sing");
	}

	public void OnButtonReleased(VirtualButtonBehaviour vh){
	}
		

	// Use this for initialization
	void Start () {

		virtualBtn = GetComponent<VirtualButtonBehaviour>();
		virtualBtn.RegisterEventHandler(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
