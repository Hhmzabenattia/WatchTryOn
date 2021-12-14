using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class colorselect : MonoBehaviour
{
    public Material band1;
    public Material band2;
    public Material band3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void w1color()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName=="BlackButton")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor); 
            band1.color = myColor; 


        }

        else if (buttonName=="BlueButton")
        {
Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#081284", out myColor); 
            band1.color = myColor; 
        }
    }

     public void w2color()
    {
              string buttonName = EventSystem.current.currentSelectedGameObject.name;
               if (buttonName=="BlackButton")
        {
Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#0E0E0E", out myColor); 
            band2.color = myColor; 
        }

        else if (buttonName=="RedButton")
        {
Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#C13523", out myColor); 
            band2.color = myColor; 
        }
  

    }
     public void w3color()
    {
              string buttonName = EventSystem.current.currentSelectedGameObject.name;
               if (buttonName=="BlackButton")
        {
Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor); 
            band3.color = myColor; 
        }

        else if (buttonName=="WhiteButton")
        {
Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#A2A2A2", out myColor); 
            band3.color = myColor; 
        }
  
    }

    
}
