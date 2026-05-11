using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    public int totalCollectibles = 0;
    private int collectedCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            collectedCount++;
            Debug.Log("Collected: " + collectedCount + " / " + totalCollectibles);

            Destroy(other.gameObject);
        }
    }

    public bool HasAllCollectibles()
    {
        return collectedCount >= totalCollectibles;
    }
}