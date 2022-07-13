using System;
using UnityEngine;

namespace Script
{
    public class Bullet : MonoBehaviour
    {
        public float speed;
        public float lifetime;
        public float distance;
        public int damage;

        private void Start()
        {
            Destroy(gameObject, lifetime);
        }
        private void Update()
        {
            RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance);
           /* if (hitInfo.collider.CompareTag($"Enemy"))
            {
                //hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
                Destroy(gameObject.CompareTag("Enemy"));   
            }*/
            //Destroy(gameObject);
            transform.Translate(Vector2.up * speed* Time.deltaTime);
        }

        private void OnTriggerEnter2D(Collider2D colision)
        {
            if (colision.CompareTag("Enemy"))
            {
                colision.GetComponent<EnemyMovement>().ApplyDamage(damage);
                Destroy(gameObject);
            }
        }
    }
}

