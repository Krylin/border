using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	public GameObject finishLine;

	public GameObject generatePrefabLink;
	public List<GameObject> spheresList = new List<GameObject>();

	public float[] generatePositions = {-1.5f, 0.0f, 1.5f};

	private int generateTime = 2;

	void Start(){
		InvokeRepeating ("generateSphere", generateTime, generateTime);
	}

	void Update () {
		foreach (GameObject item in spheresList) {
			if (item && item.transform.position.y < finishLine.transform.position.y) {
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}

	private void generateSphere(){
		float xPosition = generatePositions[Random.Range(0, generatePositions.Length)];
		Vector3 newSpherePosition = new Vector3 (xPosition, 6, 0);
		GameObject newSphere = Instantiate (generatePrefabLink, newSpherePosition, Quaternion.identity) as GameObject;
		newSphere.GetComponent<PlayerInteractive> ().gameManager = this;
		spheresList.Add (newSphere);
	}

	public void clear(GameObject itemToRemove){
		spheresList.Remove (itemToRemove);
		Destroy (itemToRemove);
	}
}
