using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class downloadtarget : MonoBehaviour
{
    // Start is called before the first frame update


    public void OpenURL()
      {
          Application.OpenURL("https://drive.google.com/file/d/1PsdS8pI3vXMD6Opfq9LoWNGhE642A-kY/view?usp=sharing");
          Debug.Log("Marker Download");
      }

         public void exitapp() 
         {
            Application.Quit();
             
         }

}
