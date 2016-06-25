using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance=this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

	void Start () {
	
	}
	
	void Update () {
	
	}

    public void test()
    {
        Debug.Log("buh");
    }
}
