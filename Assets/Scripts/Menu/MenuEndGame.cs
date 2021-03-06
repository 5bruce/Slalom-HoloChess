﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Menu
{
    public class MenuEndGame : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            if (SceneManager.GetSceneByName("dejarik").isLoaded)
            {
                SceneManager.UnloadSceneAsync("dejarik");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnSelected(GameObject gameObject)
        {
            GameManager.Instance.ResetGameManager();
            SceneManager.LoadSceneAsync("lobby");
        }
    }
}
