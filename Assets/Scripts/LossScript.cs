using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LossScript : MonoBehaviour
{
  public void Lose()
  {
    gameObject.SetActive(true);
  }

  public void TryAgain()
  {
    Debug.Log("HEEEY");
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    gameObject.SetActive(false);
  }
}
