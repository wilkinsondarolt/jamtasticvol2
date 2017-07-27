using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopdownCamera : MonoBehaviour {
    public Camera TopDownCamera;
    public float Distance = 10.0f;

    void Update () {
        TopDownCamera.transform.position = new Vector3(this.transform.position.x, this.Distance
                                                                                , this.transform.position.z - 8f);
	}
}
