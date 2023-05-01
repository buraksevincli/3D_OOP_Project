using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Managers;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.UIs
{
    public class WinConditionObject : MonoBehaviour
    {
        [SerializeField] private GameObject winConditionPanel;

        private void Awake()
        {
            if (winConditionPanel.activeSelf)
            {
                winConditionPanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucceed += HandleOnMissionSucceed;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucceed -= HandleOnMissionSucceed;
        }

        private void HandleOnMissionSucceed()
        {
            if (!winConditionPanel.activeSelf)
            {
                winConditionPanel.SetActive(true);
            }
        }
    }
}

