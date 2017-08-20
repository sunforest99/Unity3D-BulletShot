using UnityEngine;
using System.Collections;

public class SMoveSprite : MonoBehaviour
{
    Vector2 m_Vector = Vector2.zero;

    public SBullet[] m_Bullet = new SBullet[9];

    public AudioSource Audio;
    public float fSpeed = 10f;

    // Use this for initialization
    void Start()
    {
        //for (int i = 0; i < 9; i++)
        //{
        //    m_Bullet[i].bCheck = false;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        SpriteMove();
        Bullet();
    }

    void SpriteMove()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * fSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * fSpeed * Time.deltaTime);
        }
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector2.up * fSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(Vector2.down * fSpeed * Time.deltaTime);
        //}
    }

    void Bullet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 9; i++)
            {
                if (m_Bullet[i].bCheck == false)
                {
                    m_Bullet[i].BulletCreate();
                    m_Bullet[i].bCheck = true;
                    Audio.Play();
                    break;
                }
            }
        }
    }
}
