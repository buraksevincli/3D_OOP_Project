using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Managers;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.UIs
{
    public class WinConditionPanel : MonoBehaviour
    {
        public void NextClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
    }
}

