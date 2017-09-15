using UnityEngine;

public class TempRotate3DObject : MonoBehaviour {
	
	void FixedUpdate () {
        transform.Rotate(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"), 0);
	}
}