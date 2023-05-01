using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Movements;
using UnityEngine;
using UnityEngine.UI;

namespace GameFolders.Scripts.Concretes.UIs
{
    public class FuelSlider : MonoBehaviour
    {
        private Slider _fuelSlider;
        private Fuel _fuel;

        private void Awake()
        {
            _fuelSlider = GetComponent<Slider>();
            _fuel = FindObjectOfType<Fuel>();
        }

        private void Update()
        {
            _fuelSlider.value = _fuel.CurrentFuel;
        }
    }
}

