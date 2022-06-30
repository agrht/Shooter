using UnityEngine;
using Random = UnityEngine.Random;

namespace Script
{
    public class Spawner : MonoBehaviour
    {
        public GameObject EnomyPref;
        public float StartTimeBtwStart;
        public int[] YSpawnPosition;

        private float _timeBtwStart = 0;
        private bool _isPlayerNotNull;
        private PlayerMovement _playerMovement;
        
        private void Update()
        {
            if (_timeBtwStart <= 0)
            {
                //if(GameObject.Find("Player") != null)
                //{
                    int rand = Random.Range(0, YSpawnPosition.Length);
                    Instantiate(EnomyPref, new Vector2(transform.position.x, YSpawnPosition[rand]), Quaternion.identity);
                    _timeBtwStart = StartTimeBtwStart;
               // }   
            }
            else
                _timeBtwStart -= Time.deltaTime;
            //var health1 = Text.text;
           // int health = GetComponent<PlayerMovement>().Health();
        }

        /*private void LateUpdate()
        {
            if(GameObject.Find("Player")==null)
                Destroy(gameObject);
        }*/
       /* private void OnDestroy()
        {
            if(GameObject.Find("Player")==null)
                Destroy(gameObject);
        }*/
    }
}
