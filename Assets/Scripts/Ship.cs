using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Ship : MonoBehaviour
{

	public Color OriginalColor;
	
	private int Count = 0;
	
	public GameObject Balita;

	private void Start()
	{
		OriginalColor =  GetComponent<Renderer>().material.color;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(-0.3f, 0, 0);
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(0.3f, 0, 0);
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			CreateBalita();
		}
	}
	

	private void CreateBalita()
	{
		Instantiate(Balita, new Vector3(transform.position.x, transform.position.y + 2, transform.position.z), Quaternion.identity);
	}
	
	private void ChangeColor()
	{
		GetComponent<Renderer>().material.color = Color.red;
		
	}
	
	private void ResetColor()
	{
		GetComponent<Renderer>().material.color = OriginalColor;
		
	}

	

	private void OnTriggerEnter(Collider other)
	{
		if (other.name == "Rock(Clone)")
		{
			Count++;
			if (Count == 5)
			{
				Destroy(gameObject);
				Destroy(this);
			}
			else
			{
				CancelInvoke("ResetColor");
				Invoke("ResetColor", 1.0f);
				ChangeColor();	
			}
		}
	}
}
