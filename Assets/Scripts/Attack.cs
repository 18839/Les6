using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour
{
    private GameObject _foundPlayer;
    [SerializeField] private LayerMask _playerMask;

	void Update ()
    {
        FindPlayer();
	}

    void FindPlayer()
    {
        Collider[] _checkForPlayer = Physics.OverlapSphere(transform.position, 3f, _playerMask);

        if (_checkForPlayer.Length == 0)
            return;

        _foundPlayer = _checkForPlayer[0].gameObject;

        if (_foundPlayer != null)
        {
            print("Attack!");
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 3f);
    }
}
