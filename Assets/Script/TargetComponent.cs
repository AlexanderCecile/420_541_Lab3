using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetComponent : MonoBehaviour
{
	public void OnCollisionEnter(Collision collision)
    {
		Debug.Log("In OnCollisionEnter");
        if (collision.gameObject.CompareTag("Projectile"))
        {
            GameManager.Instance.IncrementScore();
            
            // Hide target after 5 seconds
            Invoke("HideTarget", 5f);
        }
    }

    void HideTarget()
    {
        gameObject.SetActive(false);
    }
}
