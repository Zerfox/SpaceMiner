using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StopButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    GameObject GameObjectPlayer;
    Player Player;
    bool isDown;
    [SerializeField]
    public float PowerStop = 3;
    // Start is called before the first frame update
    private void Awake()
    {
        GameObjectPlayer = GameObject.Find("Player");
        Player = GameObjectPlayer.GetComponent<Player>();
    }
    void Start()
    {
        
    }

    /// <summary>
    /// ўтука регирующа€ на прожатие кнопки 
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerDown(PointerEventData eventData)
    {
        this.isDown = true;
    }
    /// <summary>
    /// ўтука реагирующа€ на отпускание кнопки 
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerUp(PointerEventData eventData)
    {
        this.isDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isDown == true) 
        {
            Player.GetComponent<Rigidbody2D>().drag = PowerStop;
        }
       if (this.isDown == false) 
        {
            Player.GetComponent<Rigidbody2D>().drag = 0;
        }
    }
    
}
