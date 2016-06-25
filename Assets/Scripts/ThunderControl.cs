using UnityEngine;
using System.Collections;

public class ThunderControl : MonoBehaviour {

    public float thunderTimer = 1;
    public float thunderRepeat;
    public GameObject thunder;

	void Start () {

        InvokeRepeating("PlayThunderSound", 4, thunderRepeat);
        InvokeRepeating("PlayThunder", 3.5f, thunderRepeat);
	}
	
	void Update () {
	
	}

    void PlayThunder()
    {
        StartCoroutine(ThunderRoutine());
    }

    IEnumerator ThunderRoutine()
    {
        thunder.SetActive(true);

        while (thunderTimer > 0)
        {
            thunderTimer -= Time.deltaTime;
            yield return null;
        }
        thunder.SetActive(false);
        thunderTimer = 0.5f;
    }


    void PlayThunderSound()
    {
        GetComponent<AudioSource>().Play();
    }
}
