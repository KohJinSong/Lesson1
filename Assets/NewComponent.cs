using UnityEngine;

public class NewComponent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    Vector3 valueToMove = new Vector3(0.005f,0,0.01f);

    // Update is called once per frame
    void Update()
    {
        NewMethod();
    }

    private void NewMethod()
    {
        transform.localPosition += valueToMove;
        transform.localScale += valueToMove;

        print(transform.localPosition.y);
        print(transform.localPosition.x);
        print(transform.localPosition.z);
    }
}
