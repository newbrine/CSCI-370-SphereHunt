using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    private float counter = 0f;

    public Camera fpsCam;
    public GameObject impact;
    public TextMesh count;
    public TextMesh win;
    public TextMesh one;
    public TextMesh two;
    public TextMesh three;
    public TextMesh four;
    public TextMesh five;
    public TextMesh six;

    private string start = "Stones Found: ";

    private void Start()
    {
        win.gameObject.SetActive(false);
        SetAllFalse();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if (counter == 6)
        {
            Win();
        }
    }

    public void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //Debug.Log(hit.transform.name);
            Stones tar = hit.transform.GetComponent<Stones>();

            if (tar != null)
            {
                tar.Damage(damage);
                //hit.rigidbody.AddForce(-hit.normal * hitForce);
                //hit.rigidbody.AddForce(hit.transform.forward * hitForce);
                counter = counter + 1;
                UpdateCounter();
            }

            Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }

    void Win()
    {
        win.gameObject.SetActive(true);
    }

    void UpdateCounter()
    {
        SetAllFalse();
        if (counter == 1)
        {
            one.gameObject.SetActive(true);
        } 
        if (counter == 2)
        {
            two.gameObject.SetActive(true);
        }
        if (counter == 3)
        {
            three.gameObject.SetActive(true);
        }
        if (counter == 4)
        {
            four.gameObject.SetActive(true);
        }
        if (counter == 5)
        {
            five.gameObject.SetActive(true);
        }
        if (counter == 6)
        {
            six.gameObject.SetActive(true);
        }
    }

    void SetAllFalse()
    {
        one.gameObject.SetActive(false);
        two.gameObject.SetActive(false);
        three.gameObject.SetActive(false);
        four.gameObject.SetActive(false);
        five.gameObject.SetActive(false);
        six.gameObject.SetActive(false);
    }
}
