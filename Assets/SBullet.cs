using UnityEngine;
using System.Collections;

public class SBullet : MonoBehaviour
{
    public bool bCheck = false;
    public Vector2 m_Vector = Vector2.zero;
    public MeshRenderer m_Mesh;
    public Transform Trans;
    public float fPos = 0f;

    // Use this for initialization
    void Start()
    {
        m_Mesh.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (bCheck == true)
        {
            m_Vector.y += 0.1f;
            transform.position = m_Vector;
        }

        if (m_Vector.y > 8.5)
        {
            bCheck = false;
            m_Mesh.enabled = false;
        }
        //BulletCreate();

    }

    public void BulletCreate()
    {
        if (bCheck == false)
        {
            m_Vector.x = Trans.position.x;
            m_Vector.y = Trans.position.y + fPos;
            m_Mesh.enabled = true;
        }
    }
}
