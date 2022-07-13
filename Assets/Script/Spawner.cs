using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Script
{
    public class Spawner : MonoBehaviour
    {
        public GameObject EnemyPref;
        public float StartTimeBtwStart;
        public int[] YSpawnPosition;

        private float _timeBtwStart;
        private bool _isPlayerNotNull;
        private PlayerMovement _playerMovement;
        
        private void Update()
        {
            if (_timeBtwStart <= 0)
            {
                int rand = Random.Range(0, YSpawnPosition.Length);
                Instantiate(EnemyPref, new Vector2(transform.position.x, YSpawnPosition[rand]), Quaternion.identity);
                _timeBtwStart = StartTimeBtwStart;
            }
            else
                _timeBtwStart -= Time.deltaTime;
        }
    }
}
