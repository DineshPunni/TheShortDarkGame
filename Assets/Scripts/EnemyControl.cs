using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

    int maxXPos = 20;
    int maxZPos = 20;
    public float speed;
    public Transform target;

	void Start () {
        InvokeRepeating("RandomSpawn",5,5);
	}
	
	
    public void RandomSpawn()
    {
        int xPos = Random.Range(maxXPos*-1, maxXPos);
        int zPos = Random.Range(maxZPos*-1, maxZPos);

        gameObject.transform.position = new Vector3(xPos, 1, zPos);
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed *Time.deltaTime);
    }

}
