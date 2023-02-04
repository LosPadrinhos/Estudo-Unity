using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	float _velocidade;
	float _girar;

	void Start()
	{
		_velocidade = 3.0F;
		_girar = 90.0F;
	}

	// Update is called once per frame
	void Update()
	{
		float translate = (Input.GetAxis("Vertical") * _velocidade) * Time.deltaTime;
		float rotate = (Input.GetAxis("Horizontal") * _girar) * Time.deltaTime;

		transform.Translate(0, 0, translate);
		transform.Rotate(0, rotate, 0);
	}
}
