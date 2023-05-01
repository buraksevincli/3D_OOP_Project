using GameFolders.Scripts.Concretes.Controllers;
using GameFolders.Scripts.Concretes.Managers;
using UnityEngine;

namespace GameFolders.Scripts.Abstracts.Controllers
{
    public abstract class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController playerController = collision.collider.GetComponent<PlayerController>();

            if (playerController != null && playerController.CanMove)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

