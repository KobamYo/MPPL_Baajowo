using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{

    public GameObject LoginSignupPanel;
    
    public void PanelOpener()
    {
        if(LoginSignupPanel != null)
        {
            bool isActive = LoginSignupPanel.activeSelf;
            LoginSignupPanel.SetActive(!isActive);
        }
    }
}
