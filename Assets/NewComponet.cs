using UnityEngine;

public class NewComponet : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        print("碰撞了! collided detected!" + collision.gameObject.name);
    }

    void OnCollisionExit(Collision collision)
    {
        print("碰撞结束了! collision end with " + collision.gameObject.name);
    }

    void OnCollisionStay(Collision collision)
    {
        print("正在碰撞中! colliding with!" + collision.gameObject.name);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
