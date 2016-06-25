using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public Text youAreDead;
    public Button restart;
    public GameObject enemy;
    public GameObject player;


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

        DontDestroyOnLoad(gameObject);
    }

	
    public void YouWon()
    {
        Time.timeScale = 0;
        youAreDead.text = "You Won";
        youAreDead.color = Color.green;
        youAreDead.gameObject.SetActive(true);
        restart.gameObject.SetActive(true);

    }




    public void GameOver()
    {
        Time.timeScale = 0;
        youAreDead.text = "You are Dead";
        youAreDead.color = Color.red;
        youAreDead.gameObject.SetActive(true);
        restart.gameObject.SetActive(true);
    }


    public void Restart()
    {
        Time.timeScale = 1;
        enemy.transform.position = new Vector3(0, 2, -10);
        player.transform.position = new Vector3(0, 2, 10);
        youAreDead.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
    }
}
