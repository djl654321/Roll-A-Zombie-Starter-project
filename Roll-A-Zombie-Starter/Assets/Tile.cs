using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public GameManageer gameManger;
    public AudioClip hit;
    AudioSource source;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
        source.clip = hit;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        gameManger.AddPoint();
        source.Play();
    }

}
