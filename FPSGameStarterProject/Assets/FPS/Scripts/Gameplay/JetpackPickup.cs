
public class JetpackPickup : Pickup
{
    protected override void OnPicked(VRCharacterController byPlayer)
    {
        var jetpack = byPlayer.GetComponent<Jetpack>();
        if (!jetpack)
            return;

        if (jetpack.TryUnlock())
        {
            PlayPickupFeedback();
            Destroy(gameObject);
        }
    }
}
