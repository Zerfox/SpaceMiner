using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float powerPulce = 1f;
    private bool isDown;

    private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            RightImpulce();
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            LeftImpulce();
        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            UpImpulce();
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            DownImpulce();
        }
        if (!this.isDown) return;
        {
            rb.drag = 2;
        }
    }
  /// <summary>
  /// Кнопки движения персонажа по Х и У осям
  /// </summary>  
    public void RightImpulce()
    {
        rb.AddForce(Vector3.right * powerPulce);
    }
    public void LeftImpulce()
    {
        rb.AddForce(Vector3.left * powerPulce);
    }
    public void UpImpulce()
    {
        rb.AddForce(Vector3.up * powerPulce);
    }
    public void DownImpulce()
    {
        rb.AddForce(Vector3.down * powerPulce);
    }
    /// <summary>
    /// Кнопка остановки 
    /// </summary>
    public void StopButton()
    {
        rb.drag = 2;


    }
}

