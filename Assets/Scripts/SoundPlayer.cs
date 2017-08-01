using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour {
    public bool Loop = false;
    public AudioClip Clip;

	// Use this for initialization
	void Start () {
        if (Loop)
            SoundController.instance.PlayLoop(Clip);
        else
            SoundController.instance.PlaySingle(Clip);
        Destroy(this.gameObject);
	}	
}
