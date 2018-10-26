using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
	public Color OriginalColor;

	private int Count = 0;
	
	public GameObject Cositas;
	
	// Use this for initialization
	void Start () {
		OriginalColor =  GetComponent<Renderer>().material.color;
	}
	
	// Update is called once per frame
	void Update () {
		// Rotate the object around its local X axis at 1 degree per second
		transform.Rotate(2.0f, 2.0f, 2.0f);

	}


	private void ChangeColor()
	{
		GetComponent<Renderer>().material.color = Color.yellow;
		
	}
	
	private void ResetColor()
	{
		GetComponent<Renderer>().material.color = OriginalColor;
		
	}
	
	private void ShowCositas()
	{
		Instantiate(Cositas, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.name == "Balita(Clone)")
		{
			Count++;
			if (Count == 5)
			{
				Destroy(gameObject);
				Destroy(this);
				ShowCositas();
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
