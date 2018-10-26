using UnityEngine;

public class Spawner : MonoBehaviour
{

	public float Speed;

	private float direction = 1.0f;

	public GameObject Rock;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("LaunchRock", 1, 1);
	}

	void LaunchRock()
	{
		Instantiate(Rock, new Vector3(Random.Range(-32, 32), 25, transform.position.z), Quaternion.identity);
	}


}
