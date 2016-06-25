using UnityEngine;
using System.Collections;

public class GeneralMusicController : MonoBehaviour {

    public AudioSource source;
    private float volStart = .5f;
    private float volMax = 1.0f;

    void Start()
    {
        source.PlayDelayed(44100 * 10);
    }

    void Awake ()
    {
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (source.isPlaying && source.volume <= volMax)
        {
            source.volume = volStart + .01f;
        }
	}
}
