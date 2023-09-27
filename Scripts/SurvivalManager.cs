using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sodalite.Api;
using Sodalite.Utilities;
using UnityEngine.UI;
using localpcnerd.SurvivalMode;
using System;
#if H3VR_IMPORTED
using FistVR;

namespace localpcnerd.SurvivalMode
{
    public class SurvivalManager : MonoBehaviour
    {
        [Header("Player Spawning")]
        [Tooltip("ex. for trigger from box collider on manager object. if using UI, set to false and assign StartGame() via unity event")] public bool usePhysicalTrigger;
        public bool doTeleport;
        public Transform teleportPoint;

        [Header("Player Starting Gear")]
        public string primaryItem;
        public Transform primarySpawnPoint;
        public string primaryAmmo;
        public Transform primaryAmmoSpawnPoint;
        public int primaryAmmoAmount;
        public string[] secondaryItems;
        public Transform[] secondarySpawnPoints;

        [Header("Sosigs")]
        public SosigWaveSpawner[] Spawners;
        [Tooltip("Early round sosigs. Should be killable by small calibers.")] public SosigEnemyID[] lowTierSosigs;
        [Tooltip("Med tier sosigs. Should be killable by small-med calibers.")] public SosigEnemyID[] medTierSosigs;
        [Tooltip("Endgame/Boss sosigs. Should be a challenge to kill.")] public SosigEnemyID[] highTierSosigs;

        [Header("Rounds")]
        [Tooltip("IMPORTANT: DO NOT TOUCH. Used to determine how far into the game player is, and what enemies to spawn per round. Visible mostly for debug purposes.")] public float roundMultiplier;

        [HideInInspector] public bool gameRunning;
        [HideInInspector] public int kills;
        [HideInInspector] public float score;
        

        public enum difficulty
        {
            easy,
            med,
            hard
        }

        private void OnTriggerEnter(Collider other)
        {
            if (usePhysicalTrigger)
            {
                if (other.tag == "")
                {
                    StartGame();
                }
            }
        }

        public void StartGame()
        {
            if (doTeleport)
            {
                GM.CurrentMovementManager.TeleportToPoint(teleportPoint.position, true, teleportPoint.forward);
            }

            //initialSpawnCall();
            gameRunning = true;
            //startTimer();
        }
    }
}
#endif