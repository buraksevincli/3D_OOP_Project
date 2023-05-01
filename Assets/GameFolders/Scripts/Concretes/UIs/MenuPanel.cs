using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Managers;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.UIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void ExitClicked()
        {
            GameManager.Instance.Exit();
        }
    }
}

