using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InfoManger : MonoBehaviour
{
  public void Info1()
    {
        SceneManager.LoadSceneAsync(7);
    }
  public void Info2()
    {
        SceneManager.LoadSceneAsync(5);
    }
   public void Info3()
    {
        SceneManager.LoadSceneAsync(0);
    }

    
}
