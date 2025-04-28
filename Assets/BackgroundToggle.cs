using UnityEngine;

public class BackgroundToggle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Collider playerCollider;
    [SerializeField] private GameObject[] hideWalls;
    [SerializeField] private GameObject livingRoom;
    void Start()
    {
        foreach(GameObject wall in hideWalls){
            wall.SetActive(true);
        }
        livingRoom.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("collide");
    if (other == playerCollider) {
        Debug.Log("entered");
       foreach(GameObject wall in hideWalls){
            wall.SetActive(false);
        }
       livingRoom.SetActive(true);
    }
}
    void OnTriggerExit(Collider other) {
    if (other == playerCollider) {
        foreach(GameObject wall in hideWalls){
            wall.SetActive(true);
        }
       livingRoom.SetActive(false);
    }
}
}
