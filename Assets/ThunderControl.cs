using UnityEngine;
using System.Collections;

public class ThunderControl : MonoBehaviour {

    public float thunderTimer = 1;
    public GameObject thunder;

	void Start () {

        InvokeRepeating("PlayThunder", 1, 5);
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
        thunderTimer = 0.5fa;
    }
}
