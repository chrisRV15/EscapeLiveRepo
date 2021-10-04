using System.Collections;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject endText;
    private float time = 5;

    // Start is called before the first frame update
    void Start()
    {
        endText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            endText.SetActive(true);
            StartCoroutine(WaitSec());
        }
    }

    private IEnumerator WaitSec()
    {
        yield return new WaitForSeconds(time);
        endText.SetActive(false);
    }

 

}
