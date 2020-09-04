using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
	private AudioSource _audioSource;
	[SerializeField]
	private AudioClip _Question1;
	[SerializeField]
	//private AudioClip _Question2;

	private Collider _collider;

	private int clipNumber = 1;


	// Start is called before the first frame update
	void Start()
    {
		_audioSource = GetComponent<AudioSource>();

		if (_audioSource == null)
		{
			Debug.Log("Audio Sensor Audio Source is Null");
		}

		_collider = GetComponent<Collider>();

        if (_collider == null)
		{
			Debug.Log("Audio Sensor Collider is Null");
		}
 
    }


    private void OnTriggerEnter(Collider other)
	{

        if (other.gameObject.CompareTag("GamePlayer"))
		{
			if (clipNumber == 1)
			{
				_audioSource.clip = _Question1;

				_audioSource.Play();

				clipNumber++;

			}

			/*else if (clipNumber == 2)
			{
				_audioSource.clip = _Question2;

				AudioSource.PlayClipAtPoint(_Question2, new Vector3(0, 0, 0), 1.0f);

				clipNumber--;

			}
            */

		}
	}

}
