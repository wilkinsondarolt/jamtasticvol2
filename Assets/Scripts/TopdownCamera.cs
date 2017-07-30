using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopdownCamera : MonoBehaviour {
    public Camera TopDownCamera;
    public float XCorrection = 0f;
    public float YDistance = 10.0f;
    public float ZCorrection = 8f;

    void Update () {
        TopDownCamera.transform.position = new Vector3(this.transform.position.x + this.XCorrection, this.YDistance
                                                                                                   , this.transform.position.z - this.ZCorrection);
	}
}
