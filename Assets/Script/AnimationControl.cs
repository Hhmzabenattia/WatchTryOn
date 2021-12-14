using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public Animation anim1;
    public Animation anim2;
    public Animation anim3;



    // Start is called before the first frame update
    void Start()
    {
             Screen.orientation = ScreenOrientation.LandscapeLeft;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void anim1play()
{
    anim1["Window1"].speed= 1;
    anim1.Play();
}

public void anim2play()
{
    anim2["Window2"].speed= 1;
    anim2.Play();
    
}

public void anim3play()
{
    anim3["Window3"].speed= 1;
    anim3.Play();
    
}


public void closeanim1()
{
    anim1["Window1"].speed=-1;
    anim1.Play();


}

public void closeanim2()
{
    anim2["Window2"].speed= -1;
    anim2.Play();

}

public void closeanim3()
{
    anim3["Window3"].speed= -1;
    anim3.Play();

}




}
