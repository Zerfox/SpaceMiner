using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class RightRotationButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    GameObject GameObjectPlayer;
    Player Player;
    bool isDown;

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
    private void Awake()
    {
        GameObjectPlayer = GameObject.Find("Player");
        Player = GameObjectPlayer.GetComponent<Player>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isDown == true)
        {
            Player.GetComponent<Rigidbody2D>().rotation -= 0.2f ;
        }
    }
}