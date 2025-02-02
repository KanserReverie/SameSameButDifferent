﻿using Layer_Up.Scripts.Gameplay;
using UnityEngine;
using static Layer_Up.Scripts.Core.Simulation;

namespace Layer_Up.Scripts.Mechanics.EnvironmentInteractables
{
    /// <summary>
    /// DeathZone components mark a collider which will schedule a
    /// PlayerEnteredDeathZone event when the player enters the trigger.
    /// </summary>
    public class DeathZone : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
            {
                var ev = Schedule<PlayerEnteredDeathZone>();
                ev.deathzone = this;
            }
        }
    }
}