using UnityEngine;

public class ClickSpawner2DSimple : MonoBehaviour
{
    [SerializeField] private GameObject prefabToSpawn;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0f;

            Instantiate(prefabToSpawn, mousePos, Quaternion.identity);
        }
    }
}