using UnityEngine;

public class NewComponet : MonoBehaviour
{
    public int totalCylinders = 5;
    int collectedCount = 0;

    
    void OnCollisionEnter(Collision collision)
    {
        print("碰撞了! collided detected!" + collision.gameObject.name);
        if(collision.gameObject.name == "Cylinder")
        {
            collectedCount++;
            Debug.Log("Collected item: " + collectedCount + " / " + totalCylinders);
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Triggered by: " + collider.gameObject.name);

        if (collider.gameObject.name == "Cube")
        {
            if (collectedCount == totalCylinders)
            {
                Debug.Log("You have collected all items!");
            }
            else
            {
                Debug.Log("You have not collected all items yet.");
            }
        }
    }
    

    void OnCollisionExit(Collision collision)   
    {
        // print("碰撞结束了! collision end with " + collision.gameObject.name);
    }

    void OnCollisionStay(Collision collision)
    {
        // print("正在碰撞中! colliding with!" + collision.gameObject.name);
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
