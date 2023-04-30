using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] private GameObject fireworks;
        [SerializeField] private GameObject lights;
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController playerController = collision.collider.GetComponent<PlayerController>();

            if (playerController == null) return;
            
            if (collision.GetContact(0).normal.y == -1)
            {
                fireworks.SetActive(true);
                lights.SetActive(true);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
