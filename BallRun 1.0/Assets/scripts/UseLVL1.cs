using UnityEngine;
using UnityEngine.SceneManagement;

public class UseLVL1 : MonoBehaviour
{
    private int _coint;  

    private AudioSource _audioSource;

    public GameObject[] UpMoney = new GameObject[3];
    public GameObject Button; 

    private int scene;



    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        switch (_coint)
        {
            case 1:
                UpMoney[0].SetActive(true);
                break;

            case 2:
                UpMoney[1].SetActive(true);

                break;

            case 3:
                UpMoney[2].SetActive(true);

                break;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Money" )
        {
            _audioSource.Play();
            _coint++;
          
            Destroy(other.gameObject);     
        }

        if (other.tag == "Button")
        {                    
            Button.transform.position = new Vector3(0.69f, 0.501f, -0.02f);

            if (_coint == 3)
            {
                SceneManager.LoadScene("LVL2");
            }
            
        }
    }
}
