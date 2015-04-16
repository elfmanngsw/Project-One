using UnityEngine;
using System.Collections;

public class PlanetSpawner : MonoBehaviour {

	public GameObject planet1Prefab;
	public GameObject planet2Prefab;
	public GameObject planet3Prefab;
	public GameObject planet4Prefab;
	public GameObject planet5Prefab;
	
	float spawnDistance = 28f;
	
	void Start () {

		Vector3 offset = Random.onUnitSphere;
		offset.z = 0;
		offset = offset.normalized * spawnDistance;
		Instantiate(planet1Prefab, transform.position + offset, Quaternion.identity);
		spawnDistance = spawnDistance * 1.5f;
		offset = Random.onUnitSphere;
		offset.z = 0;
		offset = offset.normalized * spawnDistance;
		Instantiate(planet2Prefab, transform.position + offset, Quaternion.identity);
		spawnDistance = spawnDistance * 1.4f;
		offset = Random.onUnitSphere;
		offset.z = 0;
		offset = offset.normalized * spawnDistance;
		Instantiate(planet3Prefab, transform.position + offset, Quaternion.identity);
		spawnDistance = spawnDistance * 1.3f;
		offset = Random.onUnitSphere;
		offset.z = 0;
		offset = offset.normalized * spawnDistance;
		Instantiate(planet4Prefab, transform.position + offset, Quaternion.identity);
		spawnDistance = spawnDistance * 1.2f;
		offset = Random.onUnitSphere;
		offset.z = 0;
		offset = offset.normalized * spawnDistance;
		Instantiate(planet5Prefab, transform.position + offset, Quaternion.identity);
		}
}
