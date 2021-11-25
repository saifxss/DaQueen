using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MyNetworkManager : NetworkManager
{
    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        base.OnServerAddPlayer(conn);
        PlayerManager player = conn.identity.GetComponent<PlayerManager>();
        player.SetDisplayName($"Player {numPlayers}");
        Color displayColour = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        player.SetDisplayColour(displayColour);
    }

}
