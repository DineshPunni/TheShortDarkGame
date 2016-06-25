using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

    int maxXPos = 10;
    int maxZPos = 10;
    public float speed;
    public Transform target;
    public Transform spawner;
    bool succesSpawn = false;

	void Start () {
        InvokeRepeating("RandomSpawn",5,5);
	}
	
	
    public void RandomSpawn()
    { 
        
            int xPos = Random.Range((int)target.position.x - 20, (int)target.position.x + 20);
            int zPos = Random.Range((int)target.position.z - 20, (int)target.position.z + 20);

            gameObject.transform.position = new Vector3(xPos, 2, zPos);        
    }


    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed *Time.deltaTime);
        transform.LookAt(target.position);
    }

}
