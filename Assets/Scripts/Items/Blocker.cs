﻿using Pathfinding;
using ProjectStavitski.Core;
using UnityEngine;

namespace ProjectStavitski.Items
{
    public class Blocker : MonoBehaviour
    {
        private SingleNodeBlocker blocker;

        private void Start()
        {
            blocker = GetComponent<SingleNodeBlocker>();
            blocker.manager = GameManager.Instance.blockManager;
            GameManager.Instance.AddObstacleToList(blocker);
            blocker.BlockAtCurrentPosition();
        }

        private void OnDestroy()
        {
            Debug.Log("Pepe");
            blocker.Unblock();
        }
    }
}
