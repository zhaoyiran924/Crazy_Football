using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lose : MonoBehaviour {
	private Rigidbody m_Rigidbody;
	private Transform m_Transform;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if()
		//lose the game)
		m_Transform.Rotate (Vector3.up, -90);	
	}
}
