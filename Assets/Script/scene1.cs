using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class scene1 : MonoBehaviour
{
    public string scenename;
   void Start()
    {
     Screen.orientation = ScreenOrientation.Portrait;
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(scenename);

    }
}
