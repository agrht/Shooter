using UnityEngine;
using TMPro;

namespace Script
{
    public class Score: PlayerMovement
    {
        public TMP_Text textScore;
        public const int  _health = 10;
        
        private int _enemyCounter;
        private int _counter=0;
        private void OnTriggerEnter2D(Collider2D col)
        {
          /*  _enemyCounter++;
            _counter =  Mathf.Abs(_enemyCounter - _health);
            _counter = Mathf.Abs(health-_counter);*/
            textScore.text = _counter.ToString();
        }
    }
}