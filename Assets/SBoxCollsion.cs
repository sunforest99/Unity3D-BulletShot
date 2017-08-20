using UnityEngine;
using System.Collections;

public class SBoxCollsion : MonoBehaviour {

    public MeshRenderer m_mash;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerExit()
    {
        m_mash.enabled = false;
    }
}
