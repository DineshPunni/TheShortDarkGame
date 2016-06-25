using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    public bool hasKey=false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag== "Enemy")
        {
            GameManager.instance.GameOver();
        }

        if ((collision.gameObject.tag == "Door") && hasKey)
        {
            Destroy(collision.gameObject);
            GameManager.instance.YouWon();
        }
     
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            Destroy(collision.gameObject);
            hasKey = true;
        }
    }

}
