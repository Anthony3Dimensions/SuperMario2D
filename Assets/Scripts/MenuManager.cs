using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   public void PlayGame()
   {
      SceneManager.LoadScene(1);
   }

   public void Menu()
   {
      SceneManager.LoadScene(0);
   }

   public void ExitGame()
   {
      Application.Quit();
   }

   public void MenuFin()
    {
      SceneManager.LoadScene(2);
    }
}
