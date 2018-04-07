using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed = 1.0f;

	void Update () {
		transform.position = transform.position + (new Vector3(0, -speed, 0) * Time.deltaTime);
	}
}
