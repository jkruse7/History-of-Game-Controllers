using UnityEngine;

public class PedestalUI : MonoBehaviour
{
    [SerializeField] private Collider playerCollider;
    [SerializeField] private GameObject controllerUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controllerUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
    if (other == playerCollider) {
       Debug.Log("entered");
       controllerUI.SetActive(true);
    }
}
        void OnTriggerExit(Collider other) {
    if (other == playerCollider) {
       Debug.Log("exited");
       controllerUI.SetActive(false);
    }
}
}
