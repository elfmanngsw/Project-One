using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	Transform camTarget;
	// Update is called once per frame
	void Update () {
		if(camTarget == null) {
			// Find the player's ship!
			GameObject go = GameObject.FindWithTag ("Player");
			
			if(go != null) {
				camTarget = go.transform;
			}
		}
		
		// At this point, we've either found the player,
		// or he/she doesn't exist right now.
		
		if(camTarget == null)
			return;	// Try again next frame!

		if (camTarget != null) {
			Vector3 targPos = camTarget.position;
			targPos.z = transform.position.z;
			transform.position = targPos;
		}
	}
}
