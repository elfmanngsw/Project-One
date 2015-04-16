using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform camTarget;
		
	// Update is called once per frame
	void Update () {
		if (camTarget != null) {
			Vector3 targPos = camTarget.position;
			targPos.z = transform.position.z;
			transform.position = targPos;
		}
	}
}
