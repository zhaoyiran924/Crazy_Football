using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Text;

public class WaitingBody : MonoBehaviour {
	private int i=0;
	private Rigidbody m_Rigidbody;
	private Transform m_Transform;
	private bool waiting = true;
	private int nowrevolve = 180;
	// Use this for initialization
	void Start () {
		m_Rigidbody = gameObject.GetComponent<Rigidbody> ();
		m_Transform = gameObject.GetComponent<Transform> ();	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.B)) {
			waiting = false;
		}

		if(!waiting && nowrevolve >= 0)
		{
			qianzhu (1.0f);
			nowrevolve = nowrevolve -1;
		}
		if (!waiting && nowrevolve < 0) {
			waiting = true;
		}
}

	public void qianzhu(float a)
	{
		m_Transform.Rotate (-a, 0f, 0f, Space.Self);

	}
}

/*if (waiting) {
			if (Math.Ceiling (Time.realtimeSinceStartup) % 8 == 0) {
				m_Transform.Rotate (0f, 0f, 3.6f, Space.Self);
				//Debug.Log ("AS");
			}

			if (Math.Ceiling (Time.realtimeSinceStartup) % 8 == 1) {
				m_Transform.Rotate (0f, 0f, 3.6f, Space.Self);
			}
			if (Math.Ceiling (Time.realtimeSinceStartup) % 8 == 4) {
				i = i + 1;
			}
			if (i == 1) {
				Vector3 moveDirection = transform.up;
				transform.position += moveDirection * -1;
			}
			if (Math.Ceiling (Time.realtimeSinceStartup) % 8 == 5) {
				i = 0;
			}
			if (Math.Ceiling (Time.realtimeSinceStartup) % 8 == 6) {
				i = i - 1;
			}
			if (i == -1) {
				Vector3 moveDirection = transform.up;
				transform.position += moveDirection * -1;
			}
			if (Math.Ceiling (Time.realtimeSinceStartup) % 8 == 7) {
				i = 0;
			}
		}
		if (!waiting) {
			transform.localEulerAngles = new Vector3 (0, -196, 0);
			transform.position = new Vector3(-3.9f,0.31f,-7.5f);
		}
	}*/
