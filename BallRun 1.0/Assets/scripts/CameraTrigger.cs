using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;

    


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TriggerLVL")
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
    }

}
