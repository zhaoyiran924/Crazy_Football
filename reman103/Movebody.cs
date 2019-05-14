using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movebody : MonoBehaviour {

	private Rigidbody m_Rigidbody;
	private Transform m_Transform;
	private float speed = 3.5f;
	// Use this for initialization
	void Start () {
		m_Rigidbody = gameObject.GetComponent<Rigidbody> ();
		m_Transform = gameObject.GetComponent<Transform> ();
		//m_Rigidbody.MovePosition (m_Transform.position + Vector3.forward * 10);

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
            Vector3 rotation = transform.localEulerAngles;
            rotation.x = 0;
            rotation.z = 0;
            transform.localEulerAngles = rotation;
           Vector3 moveDirection = transform.forward;
			transform.position +=  moveDirection * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S)) {
            Vector3 rotation = transform.localEulerAngles;
            rotation.x = 0;
            rotation.z = 0;
            transform.localEulerAngles = rotation;
            Vector3 moveDirection = transform.forward;
			transform.position +=  moveDirection * -1 * speed * Time.deltaTime;	
		}
		if (Input.GetKey (KeyCode.A)) {
            Vector3 rotation = transform.localEulerAngles;
            rotation.x = 0;
            rotation.z = 0;
            transform.localEulerAngles = rotation;
			m_Transform.Rotate (Vector3.up, -10);	
		}
		if (Input.GetKey (KeyCode.D)) {
            Vector3 rotation = transform.localEulerAngles;
            rotation.x = 0;
            rotation.z = 0;
            transform.localEulerAngles = rotation;
            m_Transform.Rotate (Vector3.up, 10);
		}
	}

}
