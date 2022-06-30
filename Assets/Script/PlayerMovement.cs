using TMPro;
using UnityEngine;

namespace Script
{
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    public int health = 10;
    
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private new Camera camera;
    
    [SerializeField] private TMP_Text Text;
    
    private Vector2 movement;
    private Vector2 mousePos;
    private void Start()
    {
        Text.text = health.ToString();
    }
    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y ,lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
    public void ApplyDamage(int damage)
    {
        health -= damage;
        Text.text = health.ToString();
        if(health<=0)
            Destroy(gameObject);
    }
}
}

