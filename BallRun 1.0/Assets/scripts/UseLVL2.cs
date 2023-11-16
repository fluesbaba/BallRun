using UnityEngine;
using UnityEngine.SceneManagement;


public class UseLVL2 : MonoBehaviour
{
    public GameObject money;
    public GameObject Platform;
    public GameObject Platform2;
    

    private float _speedPlat = 0.1f;

    public AudioSource moneySource;
    public AudioSource teleport;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Money")
        {
            moneySource.Play();

            Platform.transform.position = new Vector3(8.721078f, 3.026f, 0 * _speedPlat * Time.fixedDeltaTime);
            


            Destroy(other.gameObject);

            money.SetActive(true);
        }

        if (other.name == "Button")
        {
            Platform2.transform.position = new Vector3(8.587f, 2.79f, 2.39f);
            transform.position = new Vector3(-8.544f, 4.75f, -8.612f);

            teleport.Play();           
        }

        if (other.tag == "TriggerLVL")
        {
            SceneManager.LoadScene("LVL3");
        }
    }
}
