public class Collector : MonoBehaviour
{
    [SerializeField] Inventory inventory = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Memory"))
        {
            Inventory.UpdateMemories(1);
            Destroy(collision.gameobject);
            // call MemorySceneLoad
        }
    }
}