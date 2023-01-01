using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���ƽ�ɫ�ƶ���������
/// </summary>
public class Player : MonoBehaviour
{

    public float speed = 5;//�ٶ�

    Rigidbody2D rbody;//�������
    
    // Start is called before the first frame update
    void Start()
    {

        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector2 position = transform.position;
        position.x += moveX * speed * Time.deltaTime;
        position.y += moveX * speed * Time.deltaTime;
        transform.position = position;
    }
}
