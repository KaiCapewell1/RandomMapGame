using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public float touchDistance = 0.5f;

    private GameObject player;
    private ResetMap resetMap;
    private MapGenerator mapGenerator;
    private bool triggered = false; // run only once

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        resetMap = FindObjectOfType<ResetMap>();
        mapGenerator = FindObjectOfType<MapGenerator>();
    }

    void Update()
    {
        if (triggered) return; // skip after triggering once

        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
            if (player == null) return;
        }

        if (Vector2.Distance(transform.position, player.transform.position) <= touchDistance)
        {
            triggered = true; // mark it triggered

            // Nuke map and generate a new one
            resetMap.Nuke();
            mapGenerator.GenerateMap();

            Destroy(gameObject); // remove this door
        }
    }
}
