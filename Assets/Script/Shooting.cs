using UnityEngine;

namespace Script
{
    public class Shooting : MonoBehaviour
    {
        public GameObject bullet;
        public Transform shotPoint;
        public float startTimeBtwShoots;
        
        private float timeBtwShoots;
        private void Update()
        {
            if(timeBtwShoots<=0)
            {
                if (Input.GetMouseButton(0))
                {
                    GameObject child = Instantiate(bullet, shotPoint.position, transform.rotation);
                    child.transform.parent = transform;
                    //Instantiate(bullet, shotPoint.position, transform.rotation);
                   timeBtwShoots = startTimeBtwShoots;
                }
            }
            else
            {
                timeBtwShoots -= Time.deltaTime;
            }
        }
    }
}

