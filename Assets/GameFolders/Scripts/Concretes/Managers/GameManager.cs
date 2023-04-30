using UnityEngine;

namespace GameFolders.Scripts.Concretes.Managers
{
    public class GameManager : MonoBehaviour
    {
        public event System.Action OnGameOver;
        public static GameManager Instance { get; private set; }

        private void Awake()
        {
            SingletonThisObject();
        }

        private void SingletonThisObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public void GameOver()
        {
            OnGameOver?.Invoke();
        }
    }
}

