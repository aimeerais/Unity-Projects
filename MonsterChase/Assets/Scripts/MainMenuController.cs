﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;
class MainMenuController : MonoBehaviour
{

    public void PlayGame()
    {
        int selectedCharacter =
            int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        GameManager.instance.CharIndex = selectedCharacter;

        SceneManager.LoadScene("Gameplay");
    }
    
    
    
    
    
} // class

