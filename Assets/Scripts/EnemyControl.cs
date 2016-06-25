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
        int jumpscare = Random.Range(1, 3);
        Debug.Log(jumpscare);
        if (jumpscare == 2 || jumpscare == 1)
        {
           // StartCoroutine(JumpscareRoutine());
        }

        while (!succesSpawn)
        {
            int xPos = Random.Range((int)target.position.x - 10, (int)target.position.x + 10);
            int zPos = Random.Range((int)target.position.z - 10, (int)target.position.z + 10);

            gameObject.transform.position = new Vector3(xPos, 2, zPos);

            if (Vector3.Distance(gameObject.transform.position, target.position) > 3)
            {
                succesSpawn = true;
            }
                
        }
        succesSpawn = false;
    }


    IEnumerator JumpscareRoutine()
    {
        Debug.Log("buh");
        gameObject.transform.position = spawner.position;
        yield return new WaitForSeconds(1);

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
