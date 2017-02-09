using UnityEngine;
using System.Collections;

public class PlayBackGround : MonoBehaviour {
    AudioSource backGround;
	// Use this for initialization
	void Start () {
        backGround=GetComponent<AudioSource>();
        backGround.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
