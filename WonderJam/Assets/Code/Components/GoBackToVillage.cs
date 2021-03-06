﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToVillage : MonoBehaviour
{
	public GameEvent m_seasonStep;
    public Scene m_villageScene;

    public void LoadScene()
    {
        SceneManager.LoadScene("Town_normal");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
			m_seasonStep.Raise();
            LoadScene();
        }
    }
}
