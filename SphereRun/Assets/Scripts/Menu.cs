﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

	public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
