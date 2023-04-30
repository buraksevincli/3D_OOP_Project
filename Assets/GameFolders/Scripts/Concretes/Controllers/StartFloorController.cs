using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class StartFloorController : MonoBehaviour
    {
        private void OnCollisionExit(Collision other)
        {
            PlayerController playerController = other.collider.GetComponent<PlayerController>();

            if (playerController != null)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

