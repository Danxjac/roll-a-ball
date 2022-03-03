using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour {

	public GameObject jugador;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - jugador.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = jugador.transform.position + offset;
	}
}
