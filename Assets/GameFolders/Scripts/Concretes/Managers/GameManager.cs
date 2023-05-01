using System.Collections;
using GameFolders.Scripts.Abstracts.Utilities;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameFolders.Scripts.Concretes.Managers
{
    public class GameManager : SingletonThisObject<GameManager>
    {
        public event System.Action OnGameOver;
        public event System.Action OnMissionSucceed;

        private void Awake()
        {
            SingletonThisGameObject(this);
        }

        public void GameOver()
        {
            OnGameOver?.Invoke();
        }

        public void MissionSucceed()
        {
            OnMissionSucceed?.Invoke();
        }

        public void LoadLevelScene(int levelIndex = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }

        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            SoundManager.Instance.StopSound(1);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
            SoundManager.Instance.PlaySound(2);
        }

        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }

        private IEnumerator LoadMenuSceneAsync()
        {
            SoundManager.Instance.StopSound(2);
            yield return SceneManager.LoadSceneAsync("Menu");
            SoundManager.Instance.PlaySound(1);
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}

