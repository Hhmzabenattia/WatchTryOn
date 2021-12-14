using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class scenechanger : MonoBehaviour
{
        public string scenename;

    // Start is called before the first frame update
    public void scenemanager()
    {
     SceneManager.LoadScene(scenename);
    }
}
