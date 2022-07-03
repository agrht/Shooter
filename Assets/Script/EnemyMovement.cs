using UnityEngine;

namespace Script
{
public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int damage;
    public int health = 1;
    
    public Rigidbody2D rb;
    public GameObject player;

    private Vector2 movement;
    private Vector2 mousePos;
    
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    private void Update()
    { 
        var position = player.transform.position;
        mousePos = position;
        movement.x = position.x;
        movement.y = position.y;
        if (health == 0)
        {
            PlayerMovement.enemyCounter ++;
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y ,lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
        transform.Translate((movement - rb.position) * moveSpeed * Time.deltaTime);
    }
    private void LateUpdate()
    {
        if(GameObject.Find("Player")==null)
            Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.CompareTag("Player"))
        {
            colision.GetComponent<PlayerMovement>().ApplyDamage(damage);
            Destroy(gameObject);
        }
    }
    public void ApplyDamage(int damage)
    {
        health -= damage;
    }
}
}
