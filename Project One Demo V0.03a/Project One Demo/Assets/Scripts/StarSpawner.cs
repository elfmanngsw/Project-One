using UnityEngine;
using System.Collections;

public class StarSpawner : MonoBehaviour {

	public GameObject starPrefab;

	float spawnDistance = 16f;

	float starLeft = 300f;

	void Update () {

		if(starLeft > 0) {

			Vector3 offset = Random.onUnitSphere;

			offset.z = 0;

			offset = offset.normalized * spawnDistance;

			Instantiate(starPrefab, transform.position + offset, Quaternion.identity);
			starLeft--;
			spawnDistance = spawnDistance + 0.25f;
		}
	}
}