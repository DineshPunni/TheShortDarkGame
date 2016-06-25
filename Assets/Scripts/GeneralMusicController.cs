using UnityEngine;
using System.Collections;

public class GeneralMusicController : MonoBehaviour {

    public AudioClip backgroundSound;
    public AudioSource source;
    private float volStart = .5f;
    private float volMax = 1.0f;

	// Use this for initialization
	void Start () {
	    
	}

    void Awake ()
    {
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
