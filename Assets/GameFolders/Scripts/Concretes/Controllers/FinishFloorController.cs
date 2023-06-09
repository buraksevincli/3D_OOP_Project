using GameFolders.Scripts.Concretes.Managers;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] private GameObject fireworks;
        [SerializeField] private GameObject lights;
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController playerController = collision.collider.GetComponent<PlayerController>();

            if (playerController == null || !playerController.CanMove) return;
            
            if (collision.GetContact(0).normal.y == -1)
            {
                fireworks.SetActive(true);
                lights.SetActive(true);
                GameManager.Instance.MissionSucceed();
            }
            else
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

