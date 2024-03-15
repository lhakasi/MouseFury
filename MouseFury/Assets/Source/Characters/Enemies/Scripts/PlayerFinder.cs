using System;
using UnityEngine;

public class PlayerFinder : MonoBehaviour
{   
    private Transform _player;

    private void Start()
    {
        Player player = FindObjectOfType<Player>();

        if (player != null)
            _player = player.transform;
        else
            throw new NullReferenceException(nameof(player));

    }

    private void Update()
    {
        if (_player != null)
            transform.LookAt(_player.position);
        else
            throw new NullReferenceException(nameof(_player));
    }
}
