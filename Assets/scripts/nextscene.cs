using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class nextscene : UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable
{
    public void changescene(){
        SceneManager.LoadScene("credits");
    }
}

