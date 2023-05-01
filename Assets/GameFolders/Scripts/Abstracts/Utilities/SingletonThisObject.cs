using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFolders.Scripts.Abstracts.Utilities
{
    public abstract class SingletonThisObject<T> : MonoBehaviour
    {
        public static T Instance { get; private set; }

        protected void SingletonThisGameObject(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}

