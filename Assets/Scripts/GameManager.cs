using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public bool isGameOver;
    //public bool canShoot;

    public List<GameObject> enemiesInScreen = new List<GameObject>();
    // Start is called before the first frame update
   // void Start()
    {
        ShootPowerUp();

        if(Input.GetKeyDown(KeyCode.P))
        {
            KillAllEnemies();
        }
    }

    // Update is called once per frame
  //  void Update()
    {
        
    }

    //public void GameOver()
    {
        //isGameOver = true;
        //invoke("LoadScene", 1,5f)
    }


    //void LoadScene()
    {
        //SceneManager.LoadScene(0);
    }

   //IEnumerator LoadScene()
    {
       // yield return new WaitForaSecond(2.5f);
       // SceneManager.LoadScene(0);
        //StartCoroutine("LoadScene");
    }

    //if(collider.gameObject.tag == "PowerUp")
    {
        //gameManager.canShoot = true;
    }

    void KillAllEnemies()
    {
        for (int i = 0; i < enemiesInScreen.Count; i++)
        {
            Destroy(enemiesInScreen[i]);
        }
    }
    
}
