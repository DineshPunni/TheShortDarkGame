using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

    int maxXPos = 20;
    int maxZPos = 20;

	void Start () {
        InvokeRepeating("RandomSpawn",1,5);
	}
	
	void Update () {
	
	}

    public void RandomSpawn()
    {
        int xPos = Random.Range(maxXPos*-1, maxXPos);
        int zPos = Random.Range(maxZPos*-1, maxZPos);

        gameObject.transform.position = new Vector3(xPos, 1, zPos);
    }

}
