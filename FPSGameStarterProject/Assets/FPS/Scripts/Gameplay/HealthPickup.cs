
using UnityEngine;

public class HealthPickup : Pickup
{
    [Header("Parameters")]
    [Tooltip("Amount of health to heal on pickup")]
    public float HealAmount;

    protected override void OnPicked(VRCharacterController player)
    {
        Health playerHealth = player.GetComponent<Health>();
        if (playerHealth && playerHealth.CanPickup())
        {
            playerHealth.Heal(HealAmount);
            PlayPickupFeedback();
            Destroy(gameObject);
        }
    }
}
