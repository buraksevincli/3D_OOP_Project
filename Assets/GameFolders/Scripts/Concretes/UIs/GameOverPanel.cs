using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Managers;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void RetryClicked()
        {
            GameManager.Instance.LoadLevelScene();
        }

        public void MenuClicked()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
}

