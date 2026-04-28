using UnityEngine;

public class NewComponent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    Vector3 valueToMove = new Vector3(0.05f,0,0);
    bool movingRight = true;

    // Update is called once per frame
    void Update()
    {
        NewMethod();
    }
    public float rotateSpeed = 180f;
    private void NewMethod()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime, 0f, 0f);
        float Movement = transform.localPosition.x;
        if (movingRight)
        {
            transform.localPosition += valueToMove;
            // transform.localRotation = Quaternion.Euler(0, 0, 0);
            if (Movement >= 10f)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.localPosition -= valueToMove;
            // transform.localRotation = Quaternion.Euler(0, 180f, 0);
            if (Movement <= -10f)
            {
                movingRight = true;
            }
        }

        print(transform.localPosition.y);
        print(transform.localPosition.x);
        print(transform.localPosition.z);
    }
}
