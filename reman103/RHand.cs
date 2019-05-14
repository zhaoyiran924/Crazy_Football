using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Text;


public class RHand : MonoBehaviour {

	private int nowrevolve = 45;
	private int jiance1 = 0;
	private int jiance2 = 0;
	private Transform m_Transform;
	// Use this for initialization
	void Start () {
		m_Transform = gameObject.GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update ()
	{
		//Debug.Log (Time.realtimeSinceStartup);
		if (Math.Ceiling (Time.realtimeSinceStartup) % 2 == 0) {
			if (Input.GetKey (KeyCode.W) && jiance2 != 0 || Input.GetKey (KeyCode.W) && jiance2 == 0 && nowrevolve > 1) {
				jiance2 = 0;
				jiance1 = jiance1 + 1;
				//更新位置
				if (jiance1 == 1) {
					nowrevolve = 45;
				}
				if (jiance1 >= 1) {
					qianzhu (1.0f);
					//houfu (0.2f);
					nowrevolve = nowrevolve - 1;
					jiance1 = jiance1 + 1;
				}
			}
			if (Input.GetKey (KeyCode.W) && nowrevolve == 1) {
				nowrevolve = -45;
			}
			if (Input.GetKey (KeyCode.W) && nowrevolve < -1) {
				//更新位置**
				transform.localEulerAngles = new Vector3 (154, 0, 0);
				jiance1 = jiance1 + 1;
				qianzhu (-1.0f);
				//houfu (-0.2f);
				nowrevolve = nowrevolve + 1;
			}
			if (Input.GetKey (KeyCode.W) && nowrevolve == -1) {
				nowrevolve = 45;
			}

			if (Input.GetKey (KeyCode.S) && jiance1 != 0 || Input.GetKey (KeyCode.S) && jiance1 == 0 && nowrevolve > 1) {
				jiance1 = 0;
				jiance2 = jiance2 + 1;
				if (jiance2 == 1) {
					nowrevolve = 45;
				}
				if (jiance2 >= 1) {
					qianzhu (-1.0f);
					//houfu (0.2f);
					nowrevolve = nowrevolve - 1;
					jiance2 = jiance2 + 1;
				}
			}
			if (Input.GetKey (KeyCode.S) && nowrevolve == 1) {
				nowrevolve = -45;
			}
			if (Input.GetKey (KeyCode.S) && nowrevolve < -1) {
				//更新位置**
				transform.localEulerAngles = new Vector3 (154, 0, 0);
				jiance2 = jiance2 + 1;
				qianzhu (1.0f);
				//	qianfu (-0.2f);
				nowrevolve = nowrevolve + 1;
			}
			if (Input.GetKey (KeyCode.S) && nowrevolve == -1) {
				nowrevolve = 45;
			}
		} else {
			//更新位置**
			transform.localEulerAngles = new Vector3 (154, 0, 0);
		}
	}

	public void qianzhu(float a)
	{
		m_Transform.Rotate (-a, 0f, 0f, Space.Self);

	}

	public void qianfu(float b)
	{
		m_Transform.Rotate (-b, 0f, 0f, Space.Self);

	}


	public void houzhu(float a)
	{
		m_Transform.Rotate (a, 0f, 0f, Space.Self);
	}

	public void houfu(float a)
	{
		m_Transform.Rotate (a, 0f, 0f, Space.Self);
	}

}

