using UnityEngine;
using System.Collections;

public class PlayerInteractive : MonoBehaviour {
	public GameManager gameManager;

	void OnMouseDown()
	{
		gameManager.clear (gameObject);
	}
}
