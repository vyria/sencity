﻿using UnityEngine;

public class Demo3 : MonoBehaviour
{
	private string m_CameraMode = "Perspective";
	private Camera m_MainCamera;
	
	void Start ()
	{
		m_MainCamera = Camera.main;
	}
	void OnGUI ()
	{
		GUI.Label (new Rect (10, 30, 200, 30), "Camera mode: " + m_CameraMode);
		if (GUI.Button (new Rect (10, 50, 110, 25), "Perspective"))
		{
			m_MainCamera.orthographic = false;
			m_CameraMode = "Perspective";
		}
		if (GUI.Button (new Rect (10, 80, 110, 25), "Orthographic"))
		{
			m_MainCamera.orthographic = true;
			m_MainCamera.orthographicSize = 12.5f;
			m_CameraMode = "Orthographic";
		}
	}
}
