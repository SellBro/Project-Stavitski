﻿using System;
using ProjectStavitski.Core;
using UnityEngine;

namespace ProjectStavitski.Units
{
    public class EnemyUnit : Unit
    {
        [Tooltip("Number of steps to make each turn")]
        [SerializeField] private int numberOfMoves = 1;

        private int movesLeft;
        private EnemyController _controller;

        private void Awake()
        {
            _controller = GetComponent<EnemyController>();
            movesLeft = numberOfMoves;
        }

        public int GetNumberOfMoves()
        {
            return movesLeft;
        }

        public int GetTotalMoves()
        {
            return numberOfMoves;
        }

        public void IncreaseMove()
        {
            movesLeft++;
        } 
        public void DecreaseMove()
        {
            movesLeft--;
        }

        public void ResetMoves()
        {
            movesLeft = numberOfMoves;
        }

        protected override void Die()
        {
            GameManager.Instance.RemoveUnitFromList(_controller);
            _controller.UnblockGridNode();
            Destroy(gameObject);
        }
    }
}
