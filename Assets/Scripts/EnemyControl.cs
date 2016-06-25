using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

    int maxXPos = 10;
    int maxZPos = 10;
    public float speed;
    public Transform target;
    bool succesSpawn = false;

	void Start () {
        InvokeRepeating("RandomSpawn",5,5);
	}
	
	
    public void RandomSpawn()
    {
        while (!succesSpawn)
        {
            int xPos = Random.Range((int)target.position.x - 10, (int)target.position.x + 10);
            int zPos = Random.Range((int)target.position.z - 10, (int)target.position.z + 10);

            gameObject.transform.position = new Vector3(xPos, 1, zPos);

            if (Vector3.Distance(gameObject.transform.position, target.position) > 3)
            {
                succesSpawn = true;
            }
                
        }
        succesSpawn = false;
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
