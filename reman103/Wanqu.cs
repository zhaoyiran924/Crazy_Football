using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Text;

public class Wanqu : MonoBehaviour {
	private int i=0;
	private Rigidbody m_Rigidbody;
	private Transform m_Transform;
	private bool waiting = true;
	private int nowrevolve = 20;
	// Use this for initialization
	void Start () {
		m_Rigidbody = gameObject.GetComponent<Rigidbody> ();
		m_Transform = gameObject.GetComponent<Transform> ();	
	}

	// Update is called once per frame
	void Update () {
		qianzhu (3.0f);
	}

	public void qianzhu(float a)
	{
		m_Transform.Rotate (-a, 0f, 0f, Space.Self);

	}
}