using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerCollector collector = other.GetComponent<PlayerCollector>();

            if (collector != null && collector.HasAllCollectibles())
            {
                Debug.Log("You collected all collectibles and entered the trigger zone!");
            }
            else
            {
                Debug.Log("You still need to collect all collectibles first.");
            }
        }
    }
}