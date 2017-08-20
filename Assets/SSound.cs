using UnityEngine;
using System.Collections;

public class SSound : MonoBehaviour {

    public AudioSource Audio;
	// Use this for initialization
	void Start () {
        Audio.loop = true;
        Audio.Play();

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
